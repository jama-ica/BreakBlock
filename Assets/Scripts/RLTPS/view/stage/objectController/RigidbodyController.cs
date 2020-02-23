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
	public class RigidbodyController
	{
		
		readonly Rigidbody rigidbody;

		// Constructor
		public RigidbodyController(Rigidbody rigidbody)
		{
			this.rigidbody = rigidbody;
		}

		public void Move(Vector3 vec)
		{
			this.rigidbody.AddForce(vec);
		}

		public void Move(EDir dir, float val)
		{
			switch (dir)
			{
			case EDir.FORWARD:
				this.rigidbody.AddForce(Vector3.forward * val);
				break;
			case EDir.FORWARD_RIGHT:
				this.rigidbody.AddForce(Vector3.forward * val);
				this.rigidbody.AddForce(Vector3.right * val);
				break;
			case EDir.RIGHT:
				this.rigidbody.AddForce(Vector3.right * val);
				break;
			case EDir.BACK_RIGHT:
				this.rigidbody.AddForce(Vector3.right * val);
				this.rigidbody.AddForce(Vector3.back * val);
				break;
			case EDir.BACK:
				this.rigidbody.AddForce(Vector3.back * val);
				break;
			case EDir.BACK_LEFT:
				this.rigidbody.AddForce(Vector3.back * val);
				this.rigidbody.AddForce(Vector3.left * val);
				break;
			case EDir.LEFT:
				this.rigidbody.AddForce(Vector3.left * val);
				break;
			case EDir.FORWARD_LEFT:
				this.rigidbody.AddForce(Vector3.forward * val);
				this.rigidbody.AddForce(Vector3.left * val);
				break;
			default:
				Debug.LogWarning("!dir = " + dir);
				break;
			}

			// JUMP
			this.rigidbody.AddForce(Vector3.up * 0.3f, ForceMode.Impulse);
		}
		
	}
}