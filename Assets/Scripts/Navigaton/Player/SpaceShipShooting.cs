using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;

public class SpaceShipShooting : MonoBehaviour {

	public delegate void onRotateAmmo(int ShotValue);
	public static event onRotateAmmo ammoRotated;

	public int ShotValue = 0;
	public GameObject Bullet;

	public Problem[] ProblemArray;

	// Use this for initialization
	void Start () {
		ProblemArray = Problem.GenerateArrayProblemsForTimesTable(6);
		if (ammoRotated != null) {
			ammoRotated (ShotValue);
		}	
	}
	
	// Update is called once per frame
	void Update () {
		//Call Shoot
		//if (Input.GetAxis("Fire1") > 0.0f) {
		if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0)){
			Shoot ();
		}
		//if (Input.GetAxis("Fire2") > 0.0f) {
		if(Input.GetKeyDown(KeyCode.R)||Input.GetMouseButtonDown(1)){
			RotateAmmo ();
		}
	}

	void Shoot () {
		GameObject bullet = Instantiate (Bullet, gameObject.transform.position, gameObject.transform.rotation);
		bullet.GetComponent<BulletBehavior>().SolutionValue = ProblemArray[ShotValue];

		RotateAmmo ();
	}

	void RotateAmmo () {
		
		//Add 1 to shot value
		ShotValue += 1;

		//if 6, turn back to 1
		if (ShotValue >= 5){
			ShotValue = 0;
		}

		if (ammoRotated != null) {
			ammoRotated (ShotValue);
		}
			
	}
}
