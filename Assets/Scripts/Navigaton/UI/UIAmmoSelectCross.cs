using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MultiplicationGame;

public class UIAmmoSelectCross : MonoBehaviour {

	private TextMeshPro ammoSelectText;
	Problem[] answers;

	void Awake() {
		ammoSelectText = gameObject.GetComponent<TextMeshPro>();
		//ammoSelectText = ;

		SpaceShipShooting.ammoRotated += OnAmmoRotated;
		answers = Problem.GenerateArrayProblemsForTimesTable(TimesTableSelect.CurrentTimesTable);
	}

	void OnDestroy() {
		SpaceShipShooting.ammoRotated -= OnAmmoRotated;
		}

	void OnAmmoRotated(int ShotValue)
	{
		//Debug.Log
		ammoSelectText.text = answers[ShotValue].Answer.ToString();
	} 


}
