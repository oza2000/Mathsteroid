using System;
using UnityEngine;

namespace MultiplicationGame
{
	public class AfterSecondAnswer: ILoadingBayState
	{
		Animator m_SpaceshipAnimator;
		Animator m_BoxAnimator;
		Problem m_CurrentProblem;

		public AfterSecondAnswer (Animator SpaceshipAnimator, Animator BoxAnimator, Problem currentProblem)
		{
			m_SpaceshipAnimator = SpaceshipAnimator;
			m_BoxAnimator = BoxAnimator;
			m_CurrentProblem = currentProblem;
		}
		void ILoadingBayState.onEnterState()
		{
			m_SpaceshipAnimator.SetTrigger ("afterSecondAnswer");
			m_BoxAnimator.SetTrigger ("bAfterSecondAnswer");
		}
		bool ILoadingBayState.isAnswerCorrect(int Answer)
		{
			return m_CurrentProblem.IsCorrectAnswer(Answer);
		}
			
		bool ILoadingBayState.needsInputToProgress()
		{
			return true;
		}
		float ILoadingBayState.getEndOfStateDelayTime ()
		{
			return 0.0f;
		}
	}
}

