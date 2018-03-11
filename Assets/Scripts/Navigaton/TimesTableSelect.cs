using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimesTableSelect : MonoBehaviour {

	private static TimesTableSelect _instance;

	public static int timesTableHouseIndex = 0;
	public TextMeshPro dspTimesTable;

	public static int CurrentTimesTable { get { return candidateNumbersHouse [timesTableHouseIndex]; } }

	public static int[] candidateNumbersHouse = {0,3,4,6,7,8};
	private static int SecretCount = 0;
	private static int secretThreshold = 50;

	private bool isTrigger;

	//VOID AWAKE
	void Awake (){
		if (!_instance)
			_instance = this;
		else
			Destroy(this.gameObject);

		DontDestroyOnLoad (_instance.gameObject);
	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (dspTimesTable != null) {
			dspTimesTable.enabled = scene.buildIndex == 1;
		}
	}

	// Use this for initialization
	void Start () {
		dspTimesTable = gameObject.GetComponent<TextMeshPro>();
		dspTimesTable.text = candidateNumbersHouse[timesTableHouseIndex].ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			isTrigger = true;
		}
		else{
			isTrigger = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Player") && isTrigger == true){
			switchHouse();
		}
	}

	void switchHouse (){
		timesTableHouseIndex += 1;
		SecretCount += 1;
		if (timesTableHouseIndex >= candidateNumbersHouse.Length && SecretCount >= secretThreshold) {
			timesTableHouseIndex = 0;
		}
		if (timesTableHouseIndex >= candidateNumbersHouse.Length && SecretCount < secretThreshold) {
			timesTableHouseIndex = 1;
		}
		dspTimesTable.text = candidateNumbersHouse[timesTableHouseIndex].ToString ();
	}
}
