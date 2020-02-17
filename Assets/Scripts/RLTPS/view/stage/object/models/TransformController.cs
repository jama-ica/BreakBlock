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
	public class TransformController
	{
		readonly Transform transform;
		
		// Constructor
		public TransformController(Transform transform)
		{
			this.transform = transform;
		}

		public void Move(EDir dir, float val)
		{
			switch (dir)
			{
			case EDir.FORWARD:
				this.transform.Translate(Vector3.forward * val);
				break;
			case EDir.FORWARD_RIGHT:
				this.transform.Translate(Vector3.forward * val);
				this.transform.Translate(Vector3.right * val);
				break;
			case EDir.RIGHT:
				this.transform.Translate(Vector3.right * val);
				break;
			case EDir.BACK_RIGHT:
				this.transform.Translate(Vector3.right * val);
				this.transform.Translate(Vector3.back * val);
				break;
			case EDir.BACK:
				this.transform.Translate(Vector3.back * val);
				break;
			case EDir.BACK_LEFT:
				this.transform.Translate(Vector3.back * val);
				this.transform.Translate(Vector3.left * val);
				break;
			case EDir.LEFT:
				this.transform.Translate(Vector3.left * val);
				break;
			case EDir.FORWARD_LEFT:
				this.transform.Translate(Vector3.forward * val);
				this.transform.Translate(Vector3.left * val);
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
			this.transform.Rotate(0.0f, x, 0.0f, Space.Self);
			// if(this.gameObj.transform.rotation.x != x){
			// 	this.gameObj.transform.rotation = Quaternion.Euler(0.0f, x, 0.0f);
			// }
		}
	}
}