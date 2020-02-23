using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using MessagePack;
using MessagePack.Resolvers;
using MasterMemory;
using RLTPS.Model;
using RLTPS.Control;
using RLTPS.Resource;
using RLTPS.Scene;
using RLTPS.View.Entity;
using RLTPS.View.Stage;
using RLTPS.View;
using RLTPS.Device;
using RLTPS.View.Command;

namespace RLTPS
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : MonoBehaviour
	{
		GameModel gameModel;
		DeviceManager deviceManager;
		ResourceManager resourceManager;
		Controller controller;
		// view
		ViewManager viewManager;
		EntityManager entityManager;
		ViewCommandProcessor viewCommandProcessor;
		// scene
		SceneManager sceneManager;
		
		// Constructor
		public Game()
		{
			this.gameModel = new GameModel();
			this.deviceManager = new DeviceManager();
			this.resourceManager = new ResourceManager();
			this.controller = new Controller(this.gameModel, this.resourceManager);

			this.viewManager = new ViewManager(this.resourceManager, this.deviceManager);
			this.entityManager = new EntityManager();
			this.viewCommandProcessor = new ViewCommandProcessor(this.controller, this.resourceManager, this.viewManager, this.entityManager);

			this.sceneManager = SceneManagerFactory.Create(this.controller, this.viewManager, this.resourceManager, this.entityManager);

			// Init
			this.controller.Init(this.viewCommandProcessor);
		}

		[RuntimeInitializeOnLoadMethod (RuntimeInitializeLoadType.BeforeSceneLoad)]
		public static void SetupMessagePackResolver () {
			var resolver = MessagePack.Resolvers.CompositeResolver.Create(
				MasterMemoryResolver.Instance, // set MasterMemory generated resolver
				GeneratedResolver.Instance, // set MessagePack generated resolver
				StandardResolver.Instance // set default MessagePack resolver
			);
			var options = MessagePackSerializerOptions.Standard.WithResolver(resolver);
			// pass options to every time or set as default
			MessagePackSerializer.DefaultOptions = options;
		}

		public void Awake()
		{
		}

		public void Start()
		{

			Cursor.lockState = CursorLockMode.Confined;
			//Cursor.visible = false;

			this.sceneManager.Start();
		}

		public void Update()
		{
			this.sceneManager.Update(Time.deltaTime);
		}

		public void FixedUpdate()
		{
			this.sceneManager.FixedUpdate();
		}

		// public void OnGUI()
		// {
		// }
		
	}
}
