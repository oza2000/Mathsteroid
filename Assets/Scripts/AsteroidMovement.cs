﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		// Initial Velocity
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
