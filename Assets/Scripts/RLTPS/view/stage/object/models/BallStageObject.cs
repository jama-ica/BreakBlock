using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using UniRx.Triggers;
using RLTPS.Resource;
using RLTPS.View.Sound;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class BallStageObject : StageObject
	{

		TransformController transformController;
		//RigidbodyController rigidbodyController;
		ObservableCollisionTrigger trigger;
		readonly SoundPlayer soundPlayer;
		EAudioSourceID audioSourceID;

		// Constructor
		public BallStageObject(ViewStage stage, ResourceManager resouceManager, SoundPlayer soundPlayer)
			: base(stage, resouceManager)
		{
			this.transformController = null;
			this.trigger = null;
			this.soundPlayer = soundPlayer;
			this.audioSourceID = EAudioSourceID.NONE;
		}

		public ObservableCollisionTrigger Trigger { get { return this.trigger; } }

		//----------------------------------------------------
		//	Resource
		//----------------------------------------------------
		protected override EPrefabType GetModelPrefabType(){ return EPrefabType.Ball; }

		static ESoundSEType[] SoundSETypes = {
			ESoundSEType.Hoge,
		};
		protected override ESoundSEType[] GetSoundSETypes(){ return SoundSETypes; }

		public override void End()
		{
			base.End();
			this.soundPlayer.RemoveAudioSource(this.audioSourceID);
		}

		//----------------------------------------------------
		//	Stage
		//----------------------------------------------------
		public void Stage(float x, float y, float z)
		{
			var gameObj = Stage(GetModelPrefabType(), x, y, z);
			OnStaged(gameObj);
		}

		void OnStaged(GameObject gameObj)
		{
			this.transformController = new TransformController(gameObj.transform);
			//--
			this.trigger = gameObj.AddComponent<ObservableCollisionTrigger>();
			//--
			this.audioSourceID = this.soundPlayer.AddAudioSource(gameObj.AddComponent<AudioSource>());
		}

		//----------------------------------------------------
		//	Sound
		//----------------------------------------------------
		public void PlaySE(ESoundSEType seType)
		{
			this.soundPlayer.PlaySE(this.audioSourceID, seType);
		}

		//----------------------------------------------------
		//	Control
		//----------------------------------------------------
		public void Move(Vector3 vec)
		{
			Assert.IsNotNull(this.transformController);
			this.transformController.Move(vec);
		}

	}
}