using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using RLTPS.Util;

namespace RLTPS.Stage
{
	/// <summary>
	/// 
	/// </summary>
	public class GameStage
	{
		StageCamera camera;
		UtilArray<IActor> actors;
		UtilArray<Stage.IProp> props;
		
		// Constructor
		public GameStage()
		{
			this.camera = new StageCamera();
			this.actors = new UtilArray<IActor>(100);
			this.props = new UtilArray<Stage.IProp>(100);
		}

		public void Update()
		{
			for( int i = 0, size = this.actors.Count() ; i < size ; i++ )
			{
				var actor = this.actors.Get(i);
				if( actor is null ){
					continue;
				}
				actor.Update();
			}
		}

		public void ClearAll()
		{

		}

		/*---------------------------------------
			Actor
		  ---------------------------------------*/
		public Stage.EActorID AddActor(IActor actor)
		{
			return (Stage.EActorID)this.actors.Add(actor);
		}

		public IActor GetActor(Stage.EActorID id)
		{
			return this.actors.Get((int)id);
		}

		public void RemoveActor(Stage.EActorID id)
		{
			this.actors.Remove((int)id);
		}

		/*---------------------------------------
			Prop
		  ---------------------------------------*/
		public Stage.EPropID AddProp(Stage.IProp prop)
		{
			return (Stage.EPropID)this.props.Add(prop);
		}
		
		public Stage.IProp GetProp(Stage.EPropID id)
		{
			return this.props.Get((int)id);
		}

		public void RemoveProp(Stage.EPropID id)
		{
			this.props.Remove((int)id);
		}

	}
}