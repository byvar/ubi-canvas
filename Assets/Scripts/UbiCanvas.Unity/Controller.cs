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
using UbiCanvas;

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
	public PickableSelector selector;
	public UnityPickable SelectedObject => selector.selected;

	public static Controller Obj { get; protected set; }
	public static Context MainContext { get; protected set; }
	public ContainerFile<UbiArt.ITF.Scene> MainScene { get; protected set; }

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
		Obj = this;

		Settings.Mode mode = UnitySettings.GameMode;
		string gameDataBinFolder = UnitySettings.GameDirs.ContainsKey(mode) ? UnitySettings.GameDirs[mode] : "";
		string lvlPath = UnitySettings.SelectedLevelFile;
		bool loadAnimations = UnitySettings.LoadAnimations;

		if (FileSystem.mode == FileSystem.Mode.Web) {
			gameDataBinFolder = UnitySettings.GameDirsWeb.ContainsKey(mode) ? UnitySettings.GameDirsWeb[mode] : "";
		}

		icons = Resources.LoadAll<Sprite>("tagicons");

		loadingScreen.Active = true;
		var settings = Settings.Init(mode);
		MainContext = new Context(gameDataBinFolder, settings,
			serializerLogger: new MapViewerSerializerLogger(),
			fileManager: new MapViewerFileManager(),
			systemLogger: new UnitySystemLogger(),
			asyncController: new UniTaskAsyncController());

		MainContext.Loader.loadAnimations = loadAnimations;

		await Init();
	}

	async UniTask Init() {
		Stopwatch w = new Stopwatch();
		w.Start();
		GlobalLoadState.LoadState = GlobalLoadState.State.Loading;
		await TimeController.WaitFrame();

		using (MainContext) {
			MainContext.Loader.LoadingState = "Loading initial files";
			await MainContext.Loader.LoadInitial();

			// Load main scene
			string lvlPath = UnitySettings.SelectedLevelFile;
			string pathFolder = System.IO.Path.GetDirectoryName(lvlPath);
			string pathFile = System.IO.Path.GetFileName(lvlPath);
			MainContext.Loader.LoadingState = $"Loading scene: {pathFile}";
			MainScene = await MainContext.Loader.LoadScene(new UbiArt.Path(pathFolder, pathFile));
		}
		if (MainScene != null && MainScene.obj != null) {
			GameObject sceneGao = await MainScene.obj.GetGameObject();
		}

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
		ContainerFile<Actor> act = await MainContext.Loader.LoadExtraActor(pathFile, pathFolder);
		if (act != null && act.obj != null) {
			await TimeController.WaitFrame();
			CSerializable c = await MainContext.Loader.Clone(act.obj, "act");
			GlobalLoadState.LoadState = GlobalLoadState.State.Initializing;
			Actor a = c as Actor;
			bool isAdded = scene.AddActor(a, pathFile.Substring(0, pathFile.IndexOf('.')));
			if (isAdded) {
				var sceneGao = await scene.GetGameObject();
				await a.SetGameObjectParent(sceneGao);
			}
			Controller.Obj.zListManager.Sort();
			await TimeController.WaitFrame();
		}
		GlobalLoadState.DetailedState = "Finished";
		GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
		loadingScreen.Active = false;
	}

	public async UniTask ExportActor(Actor actor, string path) {
		GlobalLoadState.LoadState = GlobalLoadState.State.Loading;
		loadingScreen.Active = true;
		byte[] actorBytes = await MainContext.Loader.WriteActorFile(actor);
		if (actorBytes != null)
			Util.ByteArrayToFile(path, actorBytes);

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
					loadingScreen.LoadingText = MainContext.Loader.LoadingState;
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
		if (MainContext != null) {
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
