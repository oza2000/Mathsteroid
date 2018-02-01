using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MultiplicationGame;

public class UIAmmoSelect : MonoBehaviour {
	private Text Ammo;
	Problem[] answers;

	void Awake() {
		Ammo = gameObject.GetComponent<Text> ();
		SpaceShipShooting.ammoRotated += OnAmmoRotated;
		answers = Problem.GenerateArrayProblemsForTimesTable(6);
	}

	void Destroy() {
		SpaceShipShooting.ammoRotated -= OnAmmoRotated;
	}

	void OnAmmoRotated(int ShotValue)
	{
		//Debug.Log
		if (Ammo != null) {
			Ammo.text = answers [ShotValue].Answer.ToString ();
		}
	} 
}
