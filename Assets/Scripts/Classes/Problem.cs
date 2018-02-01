using UnityEngine;
using System.Collections.Generic;
namespace MultiplicationGame
{
	public class Problem
	{
		public int firstNumber;
		public int secondNumber;
		//Constructor
		public Problem(int first, int second)
		{
			firstNumber = first;
			secondNumber = second;
		}
		//Define Correct Answer
		public bool IsCorrectAnswer(int answer)
		{
			return this.Answer == answer;
		}
		//Define Answer
		public int Answer
		{
			get {
				return (firstNumber * secondNumber);
				} 
		}
		//String
		public string QuestionString { 
			get {return firstNumber + "x" + secondNumber;}
		}
		//Gen a random Problem
		public static Problem GenerateRandomProblemsForTimesTable(int number)
		{
			int[] candidateNumbers = {3,4,6,7,8};
			return new Problem (number, candidateNumbers [Random.Range (0, candidateNumbers.Length - 1)]);
		}
		//Gen an array of problems
		public static Problem[] GenerateArrayProblemsForTimesTable(int number)
		{
			int[] candidateNumbers = {3,4,6,7,8};
			Problem[] problems = new Problem[5];
			for (int i = 0; i < problems.Length; i++) {
				Problem problem = new Problem (number, candidateNumbers [i]);
				problems [i] = problem;
			}
			return problems;
		}
		//Gen a list
		public static List<Problem> GenerateListProblemsForTimesTable(int number)
		{
			int[] candidateNumbers = {3,4,6,7,8};
			List<Problem> problems = new List<Problem>();
			for (int i = 0; i < candidateNumbers.Length; i++) {
				Problem problem = new Problem (number, candidateNumbers [i]);
				problems.Add(problem);
			}
			return problems;
		}

	}
}
