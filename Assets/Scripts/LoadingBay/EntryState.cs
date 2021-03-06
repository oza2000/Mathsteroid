﻿using System;
using UnityEngine;

namespace MultiplicationGame
{
	public class EntryState: ILoadingBayState
	{
		Animator m_SpaceshipAnimator;
		Animator m_BoxAnimator;
		Problem m_CurrentProblem;

		public EntryState (Animator SpaceshipAnimator, Animator BoxAnimator, Problem currentProblem)
		{
			m_SpaceshipAnimator = SpaceshipAnimator;
			m_BoxAnimator = BoxAnimator;
			m_CurrentProblem = currentProblem;
		}
		void ILoadingBayState.onEnterState()
		{
			m_SpaceshipAnimator.SetTrigger ("Enter");
			m_BoxAnimator.SetTrigger ("bEnter");
		}
		bool ILoadingBayState.isAnswerCorrect(int Answer)
		{
			//5+ modifier
			Answer = Answer + m_CurrentProblem.secondNumber;
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

