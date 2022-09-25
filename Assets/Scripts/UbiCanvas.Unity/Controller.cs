using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Collections;
using UbiArt;
using System.Threading.Tasks;
using UbiArt.ITF;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;

public class Controller : MonoBehaviour {
	public Material baseMaterial;
	public Material baseTransparentMaterial;
	public Material baseLightMaterial;
	public Material collideMaterial;
	public Material collideTransparentMaterial;
	public LoadingScreen loadingScreen;
	public ZListManager zListManager;
	private Sprite[] icons;
	bool displayGizmos_ = false; public bool displayGizmos = false;
	MapLoader loader = null;
	public PickableSelector selector;
	public UnityPickable SelectedObject => selector.selected;

	void Awake() {
		Application.logMessageReceived += Log;
		if (Application.platform == RuntimePlatform.WebGLPlayer) {
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Assert;
		}

		// Make sure filesystem is set before checking here
		UnitySettings.ConfigureFileSystem();
	}

	// Use this for initialization
	async UniTaskVoid Start() {
		Settings.Mode mode = UnitySettings.GameMode;
		string gameDataBinFolder = UnitySettings.GameDirs.ContainsKey(mode) ? UnitySettings.GameDirs[mode] : "";
		string lvlPath = UnitySettings.SelectedLevelFile;
		string logFile = UnitySettings.LogFile;
		bool log = UnitySettings.Log;
		bool loadAnimations = UnitySettings.LoadAnimations;

		if (FileSystem.mode == FileSystem.Mode.Web) {
			gameDataBinFolder = UnitySettings.GameDirsWeb.ContainsKey(mode) ? UnitySettings.GameDirsWeb[mode] : "";
		}

		icons = Resources.LoadAll<Sprite>("tagicons");

		loadingScreen.Active = true;
		Settings.Init(mode);
		loader = MapLoader.Loader;
		loader.gameDataBinFolder = gameDataBinFolder;
		loader.pathFolder = System.IO.Path.GetDirectoryName(lvlPath);
		loader.pathFile = System.IO.Path.GetFileName(lvlPath);
		//loader.lvlName = lvlName;
		loader.logFile = logFile;
		loader.logEnabled = log;
		loader.loadAnimations = loadAnimations;
		loader.controller = this;

		await Init();
	}

	async UniTask Init() {
		Stopwatch w = new Stopwatch();
		w.Start();
		GlobalLoadState.LoadState = GlobalLoadState.State.Loading;
		await TimeController.WaitFrame();
		await loader.LoadInit();
		await TimeController.WaitFrame();
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Error) return;
		GlobalLoadState.LoadState = GlobalLoadState.State.Initializing;
		zListManager.Sort();
		print("Loading finished after " + w.ElapsedMilliseconds + "ms.");
		w.Stop();
		await TimeController.WaitFrame();
		GlobalLoadState.DetailedState = "Finished";
		GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
		loadingScreen.Active = false;
	}

	public async UniTask LoadActor(Scene scene, string pathFile, string pathFolder) {
		GlobalLoadState.LoadState = GlobalLoadState.State.Loading;
		loadingScreen.Active = true;
		ContainerFile<Actor> act = await MapLoader.Loader.LoadExtraActor(pathFile, pathFolder);
		if (act != null && act.obj != null) {
			await TimeController.WaitFrame();
			CSerializable c = await MapLoader.Loader.Clone(act.obj, "act");
			GlobalLoadState.LoadState = GlobalLoadState.State.Initializing;
			await scene.AddActor(c as Actor, pathFile.Substring(0, pathFile.IndexOf('.')));
			MapLoader.Loader.controller.zListManager.Sort();
			await TimeController.WaitFrame();
		}
		GlobalLoadState.DetailedState = "Finished";
		GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
		loadingScreen.Active = false;
	}

	public async UniTask ExportActor(Actor actor, string path) {
		GlobalLoadState.LoadState = GlobalLoadState.State.Loading;
		loadingScreen.Active = true;
		await MapLoader.Loader.WriteActor(path, actor);
		GlobalLoadState.DetailedState = "Finished";
		GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
		loadingScreen.Active = false;
	}

	// Update is called once per frame
	void Update() {
		if (loadingScreen.Active) {
			if (GlobalLoadState.LoadState == GlobalLoadState.State.Error) {
				loadingScreen.LoadingText = GlobalLoadState.DetailedState;
				loadingScreen.LoadingtextColor = UnityEngine.Color.red;
			} else {
				if (GlobalLoadState.LoadState == GlobalLoadState.State.Loading) {
					loadingScreen.LoadingText = loader.loadingState;
				} else {
					loadingScreen.LoadingText = GlobalLoadState.DetailedState;
				}
				loadingScreen.LoadingtextColor = UnityEngine.Color.white;
			}
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.G)) {
			displayGizmos = !displayGizmos;
		}
		bool updatedSettings = false;
		if (loader != null) {
			if (displayGizmos != displayGizmos_) {
				updatedSettings = true;
			}
		}
		if (updatedSettings) {
			//communicator.SendSettings();
		}
	}

	public void Log(string condition, string stacktrace, LogType type) {
		switch (type) {
			case LogType.Exception:
			case LogType.Error:
				if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) {
					// Allowed exceptions
					if (condition.Contains("cleaning the mesh failed")) break;

					// Go to error state
					GlobalLoadState.LoadState = GlobalLoadState.State.Error;
					if (loadingScreen.Active) {
						GlobalLoadState.DetailedState = condition;
					}
				}
				break;
		}
	}

	public Sprite GetIcon(string name, bool selected = false) {
		if (selected) {
			return icons.FirstOrDefault(s => s.name == $"{name}_s") ?? icons.FirstOrDefault(s => s.name == name);
		} else {
			return icons.FirstOrDefault(s => s.name == name);
		}
	}
}
