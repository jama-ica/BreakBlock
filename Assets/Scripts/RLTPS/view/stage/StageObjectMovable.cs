using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class StageObjectMovable : StageObject
	{
		Transform transform;

		// Constructor
		public StageObjectMovable()
			: base()
		{
			this.transform = null;
		}

		public override void SetGameObj(GameObject gameObj)
		{
			this.transform = gameObj.transform;
			base.SetGameObj(gameObj);
		}

		public void Move(EDir dir, float val)
		{
			switch (dir)
			{
			case EDir.FORWARD:
				this._gameObj.transform.Translate(Vector3.forward * val);
				break;
			case EDir.FORWARD_RIGHT:
				this._gameObj.transform.Translate(Vector3.forward * val);
				this._gameObj.transform.Translate(Vector3.right * val);
				break;
			case EDir.RIGHT:
				this._gameObj.transform.Translate(Vector3.right * val);
				break;
			case EDir.BACK_RIGHT:
				this._gameObj.transform.Translate(Vector3.right * val);
				this._gameObj.transform.Translate(Vector3.back * val);
				break;
			case EDir.BACK:
				this._gameObj.transform.Translate(Vector3.back * val);
				break;
			case EDir.BACK_LEFT:
				this._gameObj.transform.Translate(Vector3.back * val);
				this._gameObj.transform.Translate(Vector3.left * val);
				break;
			case EDir.LEFT:
				this._gameObj.transform.Translate(Vector3.left * val);
				break;
			case EDir.FORWARD_LEFT:
				this._gameObj.transform.Translate(Vector3.forward * val);
				this._gameObj.transform.Translate(Vector3.left * val);
				break;
			default:
				Debug.LogWarning("!dir = " + dir);
				break;
			}
		}
		
		public void Rotate(float x)
		{
			if(0.0f == x){
				return;
			}
			this._gameObj.transform.Rotate(0.0f, x, 0.0f, Space.Self);
			// if(this.gameObj.transform.rotation.x != x){
			// 	this.gameObj.transform.rotation = Quaternion.Euler(0.0f, x, 0.0f);
			// }
		}
	}
}