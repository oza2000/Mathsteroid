using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICurrentHouse : MonoBehaviour {

	private Text dspHouse;

	void Awake() {
		dspHouse = gameObject.GetComponent<Text> ();
	}
	void Start(){
		dspHouse.text = (TimesTableSelect.CurrentTimesTable).ToString();
	}

}
