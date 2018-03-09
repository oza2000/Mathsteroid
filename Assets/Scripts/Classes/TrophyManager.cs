using System;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

namespace MultiplicationGame
{
	public class TrophyManager
	{
		static public playerTrophyData gameData;
		static string trophyFileData = "tropies.json";

		//Load or Create
		static public void LoadGameData()
		{
			string filePath = Path.Combine(Application.dataPath, trophyFileData) ;
			//FILEPATH
			Debug.Log (filePath);

			if (File.Exists (filePath)) {
				string dataAsJson = File.ReadAllText (filePath);
				gameData = JsonUtility.FromJson<playerTrophyData> (dataAsJson);
			} else 
			{
				gameData = new playerTrophyData();
			}
		}

		//Save
		static public void SaveGameData()
		{
			string dataAsJson = JsonUtility.ToJson (gameData);

			string filePath = Application.dataPath + trophyFileData;
			File.WriteAllText (filePath, dataAsJson);
		}

		static public void PlayerCompletedLevel(int currentTimesTable){
		
			LoadGameData ();
			gameData.trophies [currentTimesTable] = true;
			SaveGameData ();
		}

		static public playerTrophyData GetGameData() {
			LoadGameData ();
			return gameData;
		}


	}
}

