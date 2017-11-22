using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	public GameObject skin;
	private GameObject skinInstance;

	// Use this for initialization
	void Start () {
		skinInstance = Instantiate (skin, gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = skinInstance.transform.position;
		pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		pos = new Vector3(pos.x, pos.y, 0);
		skinInstance.transform.position = pos;
	}
}
