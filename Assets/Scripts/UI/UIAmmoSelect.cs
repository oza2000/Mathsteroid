using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAmmoSelect : MonoBehaviour {
	private Text Ammo;
	string[] answers = {"3","4","6","7","8"};

	void Awake() {
		Ammo = gameObject.GetComponent<Text> ();
		SpaceShipShooting.ammoRotated += OnAmmoRotated;
	}

	void Destroy() {
		SpaceShipShooting.ammoRotated -= OnAmmoRotated;
	}

	void OnAmmoRotated(int ShotValue)
	{
		//Debug.Log
		Ammo.text = ShotValue.ToString ();
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
