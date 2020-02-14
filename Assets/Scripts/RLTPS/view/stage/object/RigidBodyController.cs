using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace RLTPS.View.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class RigidBodyController
	{

		readonly Rigidbody rigidbody;

		// Constructor
		public RigidBodyController(Rigidbody rigidbody)
		{
			Assert.IsNotNull(rigidbody);
			this.rigidbody = rigidbody;
		}

		public void Move(float force)
		{
			this.rigidbody.AddForce(Vector3.right * 0.1f);
		}

		
		
	}
}