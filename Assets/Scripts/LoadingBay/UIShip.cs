using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MultiplicationGame;

public class UIShip : MonoBehaviour {

	private TextMeshPro ShipText;

	Problem m_currentProblem;
	int eventStateNumber;

	void Awake() {
		ShipText = gameObject.GetComponent<TextMeshPro>();
		StateControler.ProblemUpdated += onUpdateProblems;
		StateControler.ShipUpdated += onUpdateShip;
	}

	void Destroy() {
		StateControler.ProblemUpdated -= onUpdateProblems;
	}

	void onUpdateShip(int eventStateNumber)
	{
		if (eventStateNumber == 0) {
			ShipText.text = "?";
		}
		else if (eventStateNumber == 1) {
			ShipText.text = (m_currentProblem.Answer - m_currentProblem.secondNumber).ToString();
		}
		else if  (eventStateNumber == 2) {
			ShipText.text = (m_currentProblem.Answer - m_currentProblem.secondNumber).ToString();
		}
		else if  (eventStateNumber == 3) {
			ShipText.text = m_currentProblem.Answer.ToString();
		}
	}

	void onUpdateProblems(Problem currentProblem)
	{
		m_currentProblem = currentProblem;
	}

}
