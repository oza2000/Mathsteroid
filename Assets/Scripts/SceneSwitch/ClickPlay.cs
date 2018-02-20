using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPlay : MonoBehaviour {

	public int sceneIndex;
	public Scene loaded;

	// Use this for initialization
	void Start () {
		loaded = SceneManager.GetActiveScene();
		sceneIndex = loaded.buildIndex;
	}

	public void LoadGameLevel()
	{
		SceneManager.LoadScene(4);
	}

	// Update is called once per frame
	void Update () {

	}
}

