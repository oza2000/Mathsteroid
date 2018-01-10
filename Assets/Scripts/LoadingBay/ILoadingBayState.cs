using System;

namespace MultiplicationGame
{
	public interface ILoadingBayState
	{
		void onEnterState();
		void onHandleInput();
	}
}

