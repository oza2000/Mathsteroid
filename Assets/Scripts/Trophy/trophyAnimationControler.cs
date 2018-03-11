using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;

public class trophyAnimationControler : MonoBehaviour {

	public GameObject pedistal3;
	public GameObject pedistal4;
	public GameObject pedistal6;
	public GameObject pedistal7;
	public GameObject pedistal8;
	public GameObject Cube;

	// Use this for initialization
	void Start () {
		Animator Pedistal3 = pedistal3.GetComponent<Animator> ();
		Animator Pedistal4 = pedistal4.GetComponent<Animator> ();
		Animator Pedistal6 = pedistal6.GetComponent<Animator> ();
		Animator Pedistal7 = pedistal7.GetComponent<Animator> ();
		Animator Pedistal8 = pedistal8.GetComponent<Animator> ();
		Animator WinCube = Cube.GetComponent<Animator> ();

		//Check for trophies
		playerTrophyData gameData = TrophyManager.GetGameData();
		if (gameData.trophies [3])
			Pedistal3.SetTrigger ("Is3on");
		if (gameData.trophies [4])
			Pedistal4.SetTrigger ("Is4on");
		if (gameData.trophies [6])
			Pedistal6.SetTrigger ("Is6on");
		if (gameData.trophies [7])
			Pedistal7.SetTrigger ("Is7on");
		if (gameData.trophies [8])
			Pedistal8.SetTrigger ("Is8on");

		if (gameData.trophies [3] && gameData.trophies [4] && gameData.trophies [6] && gameData.trophies [7] && gameData.trophies [8])
		{
			WinCube.SetTrigger ("All Trophies");
		}
	}
}
