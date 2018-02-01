using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MultiplicationGame;
using UnityEngine.UI;

public class StateControler : MonoBehaviour {

	public int eventStateNumber;
	public GameObject SpaceshipGameObject;
	public GameObject BoxGameObject;
	public InputField InputAnswerField;
	private List <ILoadingBayState> StateList;

	//Define Problems
	private static ProblemList listOfProblems;
	private Problem currentProblem;

	public delegate void onUpdateProblems(Problem currentProblem);
	public static event onUpdateProblems ProblemUpdated;

	public delegate void onUpdateShip(int eventStateNumber);
	public static event onUpdateShip ShipUpdated;

	// Use this for initialization
	void Start () {

		updateProblems ();

		// Let the first state know that it is ready
		ILoadingBayState currentState = StateList [eventStateNumber];
		currentState.onEnterState ();

		eventStateNumber = 0;
		//0 - entry,
		//1 - after first question
		//2 - after second question
		//3 - after third question
	}

	void updateProblems ()
	{
		if (listOfProblems == null || listOfProblems.Count == 0) {
			listOfProblems = new ProblemList (6);
		}
			
		//Gen a random index to take a remove
		currentProblem = listOfProblems.PopRandomProblem ();

		Animator SpaceshipAnimator = SpaceshipGameObject.GetComponent<Animator> ();
		Animator BoxAnimator = BoxGameObject.GetComponent<Animator> ();

		StateList = new List <ILoadingBayState> ();
		StateList.Add (new EntryState (SpaceshipAnimator, BoxAnimator, currentProblem));
		StateList.Add (new AfterFirstAnswer (SpaceshipAnimator, BoxAnimator, currentProblem));
		StateList.Add (new AfterSecondAnswer (SpaceshipAnimator, BoxAnimator, currentProblem));
		StateList.Add (new AfterThirdAnswer (SpaceshipAnimator, BoxAnimator, currentProblem));

		if (ProblemUpdated != null) {
			ProblemUpdated (currentProblem);
		}
	}


	private IEnumerator getNextStateForCurrentState(ILoadingBayState currentState)
	{
		if (InputAnswerField.text != null && currentState.isAnswerCorrect (int.Parse (InputAnswerField.text))) 
		{
			eventStateNumber++;
			}
		if (eventStateNumber > 3) {
			eventStateNumber = 0;
			}
		if (ShipUpdated != null) {
			ShipUpdated (eventStateNumber);
			if (eventStateNumber == 0) {	
				updateProblems ();
			}

			// currentState = getNextStateForCurrentState (StateList [eventStateNumber]);
			ILoadingBayState newCurrentState = StateList [eventStateNumber];
			while (!newCurrentState.needsInputToProgress ()) {
				newCurrentState.onEnterState ();
				yield return new WaitForSeconds (newCurrentState.getEndOfStateDelayTime ());
				eventStateNumber++;
				if (eventStateNumber > 3) {
					eventStateNumber = 0;
				}
				if (ShipUpdated != null) {
					ShipUpdated (eventStateNumber);
				}
				if (eventStateNumber == 0) {	
					updateProblems ();
				}
				newCurrentState = StateList [eventStateNumber];
			}
			newCurrentState.onEnterState ();
		}
	}

	public void OnHandleInputEnded()
	{
		ILoadingBayState currentState = StateList [eventStateNumber];
		StartCoroutine (getNextStateForCurrentState (currentState));

	}

}
