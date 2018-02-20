using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDestroyCount : MonoBehaviour {

	private Text dstCount;
	public int DestroyCount;

	public delegate void onEndGame();
	public static event onEndGame gameEnded;

	void Awake() {
		dstCount = gameObject.GetComponent<Text> ();
		AsteroidDestroy.Destroyed += OnDestroyed;
	}

	void Destroy() {
		AsteroidDestroy.Destroyed -= OnDestroyed;
	}

	void OnDestroyed (){
		DestroyCount += 1;
		if (dstCount != null) {
			dstCount.text = DestroyCount.ToString ();

			if (DestroyCount >= 30) {
				if (gameEnded != null) {
					gameEnded ();		//Run End Game
				}
				Debug.Log ("End Game Done");
			}
		}
	}
}
