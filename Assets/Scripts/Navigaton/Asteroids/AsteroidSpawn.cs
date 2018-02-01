using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

	public GameObject Asteroid;
	public float spawnReadyTime;
	public float spawnRate;
	public int numberOfAsteroids;
	public int maxNumberOfAsteroids = 7;

	// Use this for initialization
	void Start () {
		spawnReadyTime = Time.time;
		AsteroidDestroy.Destroyed += onAsteroidDestroy;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Wall") && Time.time>spawnReadyTime && numberOfAsteroids < maxNumberOfAsteroids) {
			spawnReadyTime = Time.time + spawnRate;
			if (spawnRate > 0) {
				spawnRate -= 1;
			}

			transform.Rotate(new Vector3(0,0,Random.Range(0.0f, 360.0f)));

			GameObject asteroid = Instantiate (Asteroid, gameObject.transform.position, gameObject.transform.rotation);
			asteroid.GetComponent<AsteroidMovement>().RandomDirection();
			numberOfAsteroids += 1;


		}
	}

	void onAsteroidDestroy ()
	{
		numberOfAsteroids -= 1;
	}

	void OnDestroy ()
	{
		AsteroidDestroy.Destroyed -= onAsteroidDestroy;
	}
}
