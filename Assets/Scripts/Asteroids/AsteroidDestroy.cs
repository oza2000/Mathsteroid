using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroy : MonoBehaviour {

	public delegate void onDestroy();
	public static event onDestroy Destroyed;

	public int ProblemValue;

	string[] questions = {"6x3","6x4","6x6","6x7","6x8"};

	// Use this for initialization
	void Start () {
		ProblemValue = Random.Range (0, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bullet") && other.gameObject.GetComponent<BulletBehavior>().SolutionValue==ProblemValue) {
			Destroy (gameObject);
			Destroyed ();
		}
	}
		
}
