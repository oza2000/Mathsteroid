using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

	private Rigidbody2D Rb;

	public float speed;

	// Use this for initialization
	void Start () {
		Rb = GetComponent<Rigidbody2D> ();
		Rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
