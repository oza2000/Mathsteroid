using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MultiplicationGame;

public class UIBox : MonoBehaviour {

	private TextMeshPro BoxText;
	//Need to assign m_Current Problem to current problme

	Problem currentProblem;

	void Awake() {
		BoxText = gameObject.GetComponent<TextMeshPro>();
		StateControler.ProblemUpdated += onUpdateProblems;

	}

	void Destroy() {
		StateControler.ProblemUpdated -= onUpdateProblems;
	}
	 
	void onUpdateProblems(Problem currentProblem)
	{
			BoxText.text = currentProblem.secondNumber.ToString ();

	}
}
