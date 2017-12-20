using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

	private Rigidbody2D Rb;

	public float speed;

	private int m_SolutionValue;
	public int SolutionValue { get { return m_SolutionValue; } set { m_SolutionValue = value; } }

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
			Destroy (gameObject);
		}
		if (other.CompareTag("Asteroid")) {
			Destroy (gameObject);
		}
	}

}