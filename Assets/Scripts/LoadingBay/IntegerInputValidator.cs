using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegerInputValidator : MonoBehaviour {

	public InputField mainInputField;

	private char MyValidate(char charToValidate){
		int number;
		if (!int.TryParse (charToValidate.ToString(), out number))
			charToValidate = '\0';
		return charToValidate;
	}
	
	// Use this for initialization
	void Start () {
		mainInputField = gameObject.GetComponent<InputField> ();
		mainInputField.onValidateInput += delegate(string input, int charIndex, char addedChar) {
			return MyValidate (addedChar);
		};

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
