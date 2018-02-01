using System;
using UnityEngine;

namespace MultiplicationGame
{
	public class AfterThirdAnswer: ILoadingBayState
	{
		Animator m_SpaceshipAnimator;
		Animator m_BoxAnimator;
		Problem m_CurrentProblem;

		public int animationTime = 90;
		private float startTime;

		public AfterThirdAnswer (Animator SpaceshipAnimator, Animator BoxAnimator, Problem currentProblem)
		{
			m_BoxAnimator = BoxAnimator;
			m_SpaceshipAnimator = SpaceshipAnimator;
			m_CurrentProblem = currentProblem;
		}
		void ILoadingBayState.onEnterState()
		{
			startTime = Time.frameCount;
			m_SpaceshipAnimator.SetTrigger ("afterThirdAnswer");
			m_BoxAnimator.SetTrigger ("bAfterThirdAnswer");
		}
		bool ILoadingBayState.isAnswerCorrect(int Answer)
		{
			if(Time.frameCount >= (animationTime + startTime))
			{
				return true;
			}
			return false;
		}

		bool ILoadingBayState.needsInputToProgress()
		{
			return false;
		}

		float ILoadingBayState.getEndOfStateDelayTime ()
		{
			return 2.0f;
		}
	}
}

