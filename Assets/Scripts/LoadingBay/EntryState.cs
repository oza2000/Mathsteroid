using System;
using UnityEngine;

namespace MultiplicationGame
{
	public class EntryState: ILoadingBayState
	{
		Animator m_SpaceshipAnimator;
		Animator m_BoxAnimator;
		public EntryState (Animator SpaceshipAnimator, Animator BoxAnimator)
		{
			m_SpaceshipAnimator = SpaceshipAnimator;
			m_BoxAnimator = BoxAnimator;
		}
		void ILoadingBayState.onEnterState()
		{
			m_SpaceshipAnimator.SetTrigger ("Enter");
			m_BoxAnimator.SetTrigger ("bEnter");
		}
		void ILoadingBayState.onHandleInput()
		{
			
		}
	}
}

