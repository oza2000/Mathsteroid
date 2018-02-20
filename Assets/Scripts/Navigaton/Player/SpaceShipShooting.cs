using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;

public class SpaceShipShooting : MonoBehaviour {

	public delegate void onRotateAmmo(int ShotValue);
	public static event onRotateAmmo ammoRotated;

	public delegate void onSecondPassed();
	public static event onSecondPassed SecondTPass;

	public int ShotValue = 0;
	public GameObject Bullet;

	public Problem[] ProblemArray;

	public int overHeat = 0;

	// Next update in second
	private int nextUpdate=1;

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
		if((Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0)) && overHeat <= 3){
			Shoot ();
		}
		//if (Input.GetAxis("Fire2") > 0.0f) {
		if(Input.GetKeyDown(KeyCode.R)||Input.GetMouseButtonDown(1)){
			RotateAmmo ();
		}

		//Time
		if(Time.time>=nextUpdate){
			//Debug.Log(Time.time+">="+nextUpdate);
			// Change the next update (current second+1)
			nextUpdate=Mathf.FloorToInt(Time.time)+1;
			// Call your function
			SecondPassed();
		}
	}

	void Shoot () {
		overHeat += 1;
		GameObject bullet = Instantiate (Bullet, gameObject.transform.position, gameObject.transform.rotation);
		bullet.GetComponent<BulletBehavior>().SolutionValue = ProblemArray[ShotValue];

		for(int i = 0; i < Random.Range(1, 6); i++)
		{
			RotateAmmo ();
		}
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
	void SecondPassed () {
		if (SecondTPass != null){
			SecondTPass ();
		}
		if (overHeat >= 1) 
		{
			overHeat -= 1;
		}
	}
}
