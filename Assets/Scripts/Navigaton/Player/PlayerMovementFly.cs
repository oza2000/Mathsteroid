using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFly : MonoBehaviour {

	public float speed = 0.1f;
	public GameObject skin;
	private GameObject skinInstance;

	// Use this for initialization
	void Start () {
		skinInstance = Instantiate (skin, gameObject.transform);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Movement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		transform.Translate (new Vector2 (moveHorizontal * speed, 0), Space.World);
		transform.Translate (new Vector2 (0, moveVertical * speed), Space.World);

		//Face Direction
		Vector3 crossHairPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		crossHairPos = new Vector3(crossHairPos.x, crossHairPos.y, crossHairPos.z + 10);
		//skinInstance.transform.LookAt(crossHairPos);
		//skinInstance.transform.Rotate (new Vector3 (0, -90, 0));
		skinInstance.transform.right = crossHairPos - skinInstance.transform.position;
	}
}
