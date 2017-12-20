using UnityEngine;

public enum ProblemOperator
{
	Add,
	Divide,
	Subtract,
	Multiply
};

public class Problem
{
	public int m_FirstNumber;
	public int m_SecondNumber;
	public ProblemOperator m_Operator;


	public Problem(int first, int second, ProblemOperator op)
	{
		m_FirstNumber = first;
		m_SecondNumber = second;
		m_Operator = op;
	}

	public bool IsCorrectAnswer(int answer)
	{
		return this.Answer == answer;
	}

	public int Answer
	{
		get {
			switch(m_Operator)
			{
			case ProblemOperator.Add:
				return (m_FirstNumber + m_SecondNumber);
			case ProblemOperator.Subtract:
				return (m_FirstNumber - m_SecondNumber);
			case ProblemOperator.Divide:
				return (m_FirstNumber / m_SecondNumber);
			case ProblemOperator.Multiply:
				return (m_FirstNumber * m_SecondNumber);
			} 
			return 0;
		}
	}

	public string QuestionString { 
		get { return m_FirstNumber + "x" + m_SecondNumber; }
	}
	public static Problem[] GenerateRandomProblemsForTimesTable(int number)
	{
		int[] candidateNumbers = {3,4,6,7,8};
		Problem[] problems = new Problem[5];
		for (int i = problems.Length - 1; i >= 0; i--)
		{
			Problem problem = new Problem (number, candidateNumbers [Random.Range (0, candidateNumbers.Length - 1)], ProblemOperator.Multiply);
			problems[i] = problem;
		}
		return problems;
	}
}

