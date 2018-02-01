using System;

namespace MultiplicationGame
{
	public interface ILoadingBayState
	{
		void onEnterState();
		/// <summary>
		/// If a state does not need input to progress, we go to the next state immediately
		/// </summary>
		/// <returns><c>true</c>, if input to progress was needsed, <c>false</c> otherwise.</returns>
		bool needsInputToProgress ();

		float getEndOfStateDelayTime ();

		bool isAnswerCorrect(int Answer);
	}
}

