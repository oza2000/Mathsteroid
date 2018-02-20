using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour {

	private Text DspTimer;
	public int timer;

	void Awake() {
		DspTimer = gameObject.GetComponent<Text> ();
		SpaceShipShooting.SecondTPass += onSecondPassed;
	}

	void Destroy() {
		SpaceShipShooting.SecondTPass -= onSecondPassed;
	}
	void onSecondPassed (){
		timer += 1;
		if (DspTimer != null){
			DspTimer.text = timer.ToString();
		}
	}
}
