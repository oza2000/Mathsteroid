using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;
using TMPro;

public class AsteroidDestroy : MonoBehaviour {

	public delegate void onDestroy();
	public static event onDestroy Destroyed; 

	public Problem AstProblem;

	string[] questions = {"6x3","6x4","6x6","6x7","6x8"};

	private TextMeshPro AstText;

	// Use this for initialization
	void Start () {
		AstProblem = Problem.GenerateRandomProblemsForTimesTable (6);
		AstText = gameObject.GetComponent<TextMeshPro>();
		AstText.text = AstProblem.QuestionString;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Bullet") && other.gameObject.GetComponent<BulletBehavior>().SolutionValue.IsCorrectAnswer(AstProblem.Answer)){
			Destroy (gameObject);
			if (Destroyed != null)
				Destroyed ();
		}
	}
		
}
