using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
	public float speed = 0.1f;
	public float speedReadyTime;
	public float speedRate;

	//public Vector2 currentVel;

	// Use this for initialization
	void Awake () {
		// Initial Velocity
		RandomDirection();
	}

	void Start(){
		//currentVel = GetComponent<Rigidbody2D>().velocity;
		speedReadyTime = Time.time;
	}

	public void RandomDirection() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-speed,speed),Random.Range(-speed,speed));
	}
	// Update is called once per frame
	void Update () {
		if (speedRate > 0) {
			speedRate -= 1;
			speedReadyTime = Time.time + speedRate;
			//GetComponent<Rigidbody2D> ().velocity = (currentVel * (speed-4));
			GetComponent<Rigidbody2D> ().velocity = (GetComponent<Rigidbody2D> ().velocity * (speed-4));
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall")) {
			//currentVel = GetComponent<Rigidbody2D>().velocity;
			speed += 0.0000005f;

		}
	}
}
