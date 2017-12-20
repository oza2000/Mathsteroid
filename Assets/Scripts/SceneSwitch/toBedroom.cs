using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toBedroom : MonoBehaviour {

	private bool isTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			isTrigger = true;
		}
		else{
			isTrigger = false;
		}
		
			
		//SceneManager.LoadScene(0);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Player") && isTrigger == true){
		SceneManager.LoadScene(0);
		}
	}
}
