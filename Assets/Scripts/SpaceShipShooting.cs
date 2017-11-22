using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipShooting : MonoBehaviour {

	public float ShotValue = 0.0f;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Call Shoot
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}
		//if 6, turn back to 1

	}

	void Shoot () {
		Instantiate (Bullet, gameObject.transform.position, gameObject.transform.rotation);
	}

	void Rotate () {
		
	}
}
