using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MultiplicationGame;

public class UIGameOver : MonoBehaviour {

	private Text WinText;
	public int timer;

	void Awake() {
		WinText = gameObject.GetComponent<Text> ();
		SpaceShipShooting.SecondTPass += onSecondPassed;
		UIDestroyCount.gameEnded += onEndGame;
	}
	void Destroy() {
		SpaceShipShooting.SecondTPass -= onSecondPassed;
		UIDestroyCount.gameEnded -= onEndGame;
	}
	void onSecondPassed (){
		timer += 1;
	}

	void onEndGame (){
		if (WinText != null){
			WinText.text = "GAME OVER          Asteroid Count Reached! Time taken (Sec):" + timer.ToString() + "Press Q to reset or ESC to exit";
		}

		TrophyManager.PlayerCompletedLevel (TimesTableSelect.CurrentTimesTable);

	}
}
