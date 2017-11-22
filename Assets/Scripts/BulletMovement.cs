using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	private Rigidbody2D Rb;
	public GameObject source;

	public float speed;

	// Use this for initialization
	void Start ()
	{
		Rb = GetComponent<Rigidbody2D> ();

		//Make self vector eaual to source

		Rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
