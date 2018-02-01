using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public bool isPaused;

	public GameObject Player;

	// Use this for initialization
	void Start () {
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isPaused == (true)) {
			Time.timeScale = 0;
			if (Input.GetKeyDown (KeyCode.Q)) {
				isPaused = false;
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

			}
		}
		else if (isPaused == (false)) {
			Time.timeScale = 1;
		}

		if (Input.GetKeyUp (KeyCode.P)) {
			if (isPaused == true)
				isPaused = false;
			
			else if (isPaused == false)
				isPaused = true;
		}
	}

}
