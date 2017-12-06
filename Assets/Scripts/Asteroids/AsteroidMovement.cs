using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
	public float speed = 0.1f;

	// Use this for initialization
	void Awake () {
		// Initial Velocity
		RandomDirection();
	}

	public void RandomDirection() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-speed,speed),Random.Range(-speed,speed));
	}
	// Update is called once per frame
	void Update () {
		
	}
}
