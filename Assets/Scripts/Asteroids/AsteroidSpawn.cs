﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

	public GameObject Asteroid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall")) {
			transform.Rotate(new Vector3(0,0,Random.Range(0.0f, 360.0f)));

			GameObject asteroid = Instantiate (Asteroid, gameObject.transform.position, gameObject.transform.rotation);
			asteroid.GetComponent<AsteroidMovement>().RandomDirection();

		}
	}
}