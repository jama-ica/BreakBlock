using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Util;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public class EntityManager
	{
		UtilList<EntityObject> objects;
		UtilList<EntityBehavior> behaviors;

		// Constructor
		public EntityManager()
		{
			this.objects = new UtilList<EntityObject>(100);
			this.behaviors = new UtilList<EntityBehavior>(100);
		}

		public void Add(EntityObject obj)
		{
			obj.Start();
			this.objects.Add(obj);
		}

		public void Add(EntityBehavior behavior)
		{
			behavior.Start();
			this.behaviors.Add(behavior);
		}

		public void Update(float deltaTime)
		{
			{
				EntityObject[] array = this.objects.Array;
				EntityObject item;
				for(int i = 0, size = this.objects.Size ; i < size ; )
				{
					item = array[i];
					if( item == null ){
						break;
					}
					if( item.Alive ){
						i++;
					}else{
						item.End();
						this.objects.Remove(i);
					}
				}
			}
			{
				EntityBehavior[] array = this.behaviors.Array;
				EntityBehavior item;
				for(int i = 0, size = this.behaviors.Size ; i < size ; )
				{
					item = array[i];
					if( item == null ){
						break;
					}
					if( item.Update(deltaTime) ){
						i++;
					}else{
						this.behaviors.Remove(i);
					}
				}
			}
		}

		public void FixedUpdate()
		{
			EntityBehavior[] array = this.behaviors.Array;
			for(int i = 0, size = this.behaviors.Size ; i < size ; i++ )
			{
				array[i].FixedUpdate();
			}
		}

		public void End()
		{
			{
				EntityObject[] array = this.objects.Array;
				for(int i = 0, size = this.objects.Size ; i < size ; )
				{
					array[i].End();
				}
				this.objects.Clear();
			}
			{
				EntityBehavior[] array = this.behaviors.Array;
				for(int i = 0, size = this.behaviors.Size ; i < size ; )
				{
					array[i].End();
				}
				this.behaviors.Clear();
			}
		}

	}
}