using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;

public class StateControler : MonoBehaviour {

	public int eventStateNumber;
	public GameObject SpaceshipGameObject;
	public GameObject BoxGameObject;
	private List <ILoadingBayState> StateList;

	// Use this for initialization
	void Start () {
		Animator SpaceshipAnimator = SpaceshipGameObject.GetComponent<Animator> ();
		Animator BoxAnimator = BoxGameObject.GetComponent<Animator> ();

		StateList = new List <ILoadingBayState> ();
		StateList.Add (new EntryState (SpaceshipAnimator, BoxAnimator));

		// Add a bunch more states

		// Let the first state know that it is ready
		ILoadingBayState currentState = StateList [eventStateNumber];
		currentState.onEnterState ();



		eventStateNumber = 0;
		//0 - entry,
		//1 - first question?
		//2 - after first question
		//3 - second question?
		//4 - after second question
		//5 - third question?
		//6 - after third question
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnHandleInputEnded()
	{
		ILoadingBayState currentState = StateList [eventStateNumber];
		currentState.onHandleInput ();
	}

}
