using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D Rb;

	public GameObject Asteroid;
	public float spawnRate;

	// Use this for initialization
	void Start () {
		Rb = GetComponent<Rigidbody2D> ();
		Rb.velocity = transform.right * moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > spawnRate) {
			spawnRate = Time.time + spawnRate;
			//Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall")) {
			if (Time.time > spawnRate) {
				spawnRate = Time.time + spawnRate;
				//Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			}
		}
	}
}
