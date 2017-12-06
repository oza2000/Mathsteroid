using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	private Rigidbody2D Rb;

	public float speed;

	// Use this for initialization
	void Start ()
	{
		Rb = GetComponent<Rigidbody2D> ();

		Rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall")) {
			Debug.Log ("Hit wall");
			Destroy (gameObject);
		}
		if (other.CompareTag("Asteroid")) {
			Destroy (gameObject);
		}
	}

}
