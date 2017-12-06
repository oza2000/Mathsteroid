using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroy : MonoBehaviour {

	public int ProblemValue;

	// Use this for initialization
	void Start () {
		ProblemValue = Random.Range (1, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bullet") && other.gameObject.GetComponent<BulletBehavior>().SolutionValue==ProblemValue) {
			Destroy (gameObject);
		}
	}
}
