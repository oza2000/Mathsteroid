using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MultiplicationGame;
public class UIPointCounter : MonoBehaviour {

	private TextMeshPro CountDisplayText;
	public int count;

	void Awake() {
		CountDisplayText = gameObject.GetComponent<TextMeshPro>();
		StateControler.ShipUpdated += onUpdateShip;
	}

	// Use this for initialization
	void Start () {
		int count = 0;
	}

	void onUpdateShip(int eventStateNumber)
	{
		if (eventStateNumber == 3) {
			count += 1;
			CountDisplayText.text = count.ToString();
		}

	}

}