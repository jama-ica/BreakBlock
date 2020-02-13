using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Util;
using RLTPS.Resource;

namespace RLTPS.View.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public class EntityManager
	{
		UtilList<EntityObject> newObjects;
		UtilList<EntityBehavior> newBbehaviors;

		UtilList<EntityObject> objects;
		UtilList<EntityBehavior> behaviors;

		readonly ResourceManager resourceManager;

		// Constructor
		public EntityManager(ResourceManager resourceManager)
		{
			this.newObjects = new UtilList<EntityObject>(100);
			this.newBbehaviors = new UtilList<EntityBehavior>(100);

			this.objects = new UtilList<EntityObject>(100);
			this.behaviors = new UtilList<EntityBehavior>(100);

			this.resourceManager = resourceManager;
		}

		public void Add(EntityObject obj)
		{
			this.newObjects.Add(obj);
		}

		public void Add(EntityBehavior behavior)
		{
			this.newBbehaviors.Add(behavior);
		}

		public void Update()
		{
			// Update
			{
				int i = 0;
				while(i < this.objects.Size)
				{
					EntityObject item = this.objects.Get(i);
					if(item.Alive){
						i++;
					}else{
						item.End();
						this.objects.Remove(i);
					}
				}
			}
			{
				int i = 0;
				while(i < this.behaviors.Size)
				{
					EntityBehavior item = this.behaviors.Get(i);
					if(item.Alive){
						item.Update();
						i++;
					}else{
						item.End();
						this.behaviors.Remove(i);
					}
				}
			}

			// Copy from queue
			if(!this.newObjects.IsEmpty()){
				EntityObject[] list = this.newObjects.List;
				for(int i = 0, size = this.newObjects.Size ; i < size ; i++){
					list[i].Load(this.resourceManager);
					list[i].Start();
					this.objects.Add(list[i]);
				}
				this.newObjects.Clear();
			}
			if(!this.newBbehaviors.IsEmpty()){
				EntityBehavior[] list = this.newBbehaviors.List;
				for(int i = 0, size = this.newBbehaviors.Size ; i < size ; i++){
					list[i].Load(this.resourceManager);
					list[i].Start();
					this.behaviors.Add(list[i]);
				}
				this.newBbehaviors.Clear();
			}

		}


	}
}