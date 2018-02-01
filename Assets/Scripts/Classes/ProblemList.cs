using System;
using System.Collections.Generic;

namespace MultiplicationGame
{
	public class ProblemList : List <Problem>
	{
		public ProblemList (int TimesTable) : base(Problem.GenerateListProblemsForTimesTable (TimesTable))
		{
			
		}

		public Problem PopRandomProblem()
		{
			System.Random rand = new System.Random();
			int index = rand.Next (0, this.Count);

			Problem problem = this [index];
			this.RemoveAt (index);
			return problem;
		}
	}
}

