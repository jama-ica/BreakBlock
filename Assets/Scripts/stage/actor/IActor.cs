using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Control;
using RLTPS.Stage;
using RLTPS.View;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class IActor
	{
		Controller controller;
		GameStage stage;
		GameInput gameInput;
		SoundPlayer soundPlayer;
		EffectPlayer effectPlayer;

		// Constructor
		public IActor(Controller controller, GameStage stage, GameInput gameInput, SoundPlayer soundPlayer, EffectPlayer effectPlayer)
		{
		}

		public abstract void Update();

	}
}