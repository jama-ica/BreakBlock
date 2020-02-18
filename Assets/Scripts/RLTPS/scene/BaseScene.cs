using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UniRx;
using RLTPS.Resource;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.View.Entity;
using RLTPS.View.Input;

namespace RLTPS.Scene
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseScene
	{

		enum EStep
		{
			LoadStart,
			LoadUpdate,
			SceneStart,
			SceneUpdate,
			EndStart,
			EndUpdate,
			//--
			MAX
		}

		EStep currentStep;
		EScene _nextSceneType;

		// Constructor
		public BaseScene()
		{
			this.currentStep = EStep.MAX;
			this._nextSceneType = EScene.MAX;
		}

		public EScene NextSceneType { get{ return this._nextSceneType; } }

		public virtual void Init()
		{
			this.currentStep = EStep.LoadStart;
			this._nextSceneType = EScene.MAX;
		}

		public bool Update(float deltaTime)
		{
			switch(this.currentStep)
			{
			case EStep.LoadStart:
				this.LoadStart();
				this.currentStep = EStep.LoadUpdate;
				goto case EStep.LoadUpdate;
			
			case EStep.LoadUpdate:
				if( !this.LoadUpdate(deltaTime) ){
					this.currentStep = EStep.SceneStart;
					goto case EStep.SceneStart;
				}
				break;
			
			case EStep.SceneStart:
				this.SceneStart();
				this.currentStep = EStep.SceneUpdate;
				break;
			
			case EStep.SceneUpdate:
				this.SceneUpdate(deltaTime);
				break;
			
			case EStep.EndStart:
				this.EndStart();
				this.currentStep = EStep.EndUpdate;
				goto case EStep.EndUpdate;
			
			case EStep.EndUpdate:
				if( !this.EndUpdate(deltaTime) ){
					return false;
				}
				break;

			default:
				Debug.LogWarning("!step = " + this.currentStep);
				break;
			}
			return true;
		}

		protected abstract void LoadStart();

		protected abstract bool LoadUpdate(float deltaTime);

		protected abstract void SceneStart();

		protected abstract void SceneUpdate(float deltaTime);

		protected abstract void EndStart();

		protected abstract bool EndUpdate(float deltaTime);

		public abstract void FixedUpdate();

		protected void ChangeSceneTo(EScene type)
		{
			Assert.IsTrue(type != EScene.MAX);
			this.currentStep = EStep.EndStart;
			this._nextSceneType = type;
		}
		
	}
}
