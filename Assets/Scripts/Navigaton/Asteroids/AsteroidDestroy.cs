using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;
using TMPro;
using System;

public class AsteroidDestroy : MonoBehaviour {

	public delegate void onDestroy();
	public static event onDestroy Destroyed; 

	public Problem AstProblem;
	private static ProblemList listOfProblems;

	private TextMeshPro AstText;

	// Use this for initialization
	void Start () {
		if (listOfProblems == null || listOfProblems.Count == 0) {
			listOfProblems = new ProblemList (TimesTableSelect.CurrentTimesTable);
		}
		//Gen a random index to take a remove
		AstProblem = listOfProblems.PopRandomProblem();

		AstText = gameObject.GetComponent<TextMeshPro>();
		AstText.text = AstProblem.QuestionString;	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bullet") && other.gameObject.GetComponent<BulletBehavior>().SolutionValue.IsCorrectAnswer(AstProblem.Answer)){
			Destroy (gameObject);
			if (Destroyed != null) {
				Destroyed ();
			}
		}
	}
		
}
