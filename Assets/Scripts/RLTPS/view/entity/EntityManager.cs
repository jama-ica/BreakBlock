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
				EntityObject[] list = this.objects.List;
				EntityObject item;
				for(int i = 0, size = this.objects.Size ; i < size ; )
				{
					item = list[i];
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
				EntityBehavior[] list = this.behaviors.List;
				EntityBehavior item;
				for(int i = 0, size = this.behaviors.Size ; i < size ; )
				{
					item = list[i];
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
			EntityBehavior[] list = this.behaviors.List;
			for(int i = 0, size = this.behaviors.Size ; i < size ; i++ )
			{
				list[i].FixedUpdate();
			}
		}

		public void End()
		{
			{
				EntityObject[] list = this.objects.List;
				for(int i = 0, size = this.objects.Size ; i < size ; )
				{
					list[i].End();
				}
				this.objects.Clear();
			}
			{
				EntityBehavior[] list = this.behaviors.List;
				for(int i = 0, size = this.behaviors.Size ; i < size ; )
				{
					list[i].End();
				}
				this.behaviors.Clear();
			}
		}

	}
}