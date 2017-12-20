using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
	public float speed = 5.0f;
	public float speedReadyTime = 0.5f;
	public float speedRate = 0.00001f;

	//public Vector2 currentVel;

	// Use this for initialization
	void Awake () {
		// Initial Velocity
	}

	void Start(){
		//currentVel = GetComponent<Rigidbody2D>().velocity;
		RandomDirection();

	}

	public void RandomDirection() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-speed,speed),Random.Range(-speed,speed));
	}
	// Update is called once per frame
	void Update () {
		speedReadyTime -= Time.deltaTime;
		if (speedReadyTime <= 0) {
			speedReadyTime = 5.0f;

			//GetComponent<Rigidbody2D> ().velocity = (currentVel * (speed-4));
			GetComponent<Rigidbody2D> ().velocity = (GetComponent<Rigidbody2D> ().velocity * (1 + (speedRate)));
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall")) {
			//currentVel = GetComponent<Rigidbody2D>().velocity;
			speed += 0.0000005f;

		}
	}
}
