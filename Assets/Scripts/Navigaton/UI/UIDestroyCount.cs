using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDestroyCount : MonoBehaviour {

	private Text dstCount;
	public int DestroyCount;

	void Awake() {
		dstCount = gameObject.GetComponent<Text> ();
		AsteroidDestroy.Destroyed += OnDestroyed;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroyed (){
		DestroyCount += 1;
		dstCount.text = DestroyCount.ToString();
	}
}
