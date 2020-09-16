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

public class Controller : MonoBehaviour {
	public Material baseMaterial;
	public Material baseTransparentMaterial;
	public Material baseLightMaterial;
	public Material collideMaterial;
	public Material collideTransparentMaterial;
	public LoadingScreen loadingScreen;
	public bool forceDisplayBackfaces = false;
	public ZListManager zListManager;
	private Sprite[] icons;
	bool displayGizmos_ = false; public bool displayGizmos = false;
	MapLoader loader = null;

	private static readonly Stopwatch stopwatch = new Stopwatch();

	public enum State {
		None,
		LoadingFiles,
		Loading,
		Initializing,
		Error,
		Finished
	}
	public static State LoadState { get; set; }
	public static string DetailedState { get; set; } = "Starting";

	public static async UniTask WaitFrame() {
		await UniTask.WaitForEndOfFrame();

		if (stopwatch.IsRunning) stopwatch.Restart();
	}

	public static void StartStopwatch() {
		stopwatch.Start();
	}
	public static void StopStopwatch() {
		if (stopwatch.IsRunning) stopwatch.Stop();
	}
	public static async UniTask WaitIfNecessary() {
		if (!stopwatch.IsRunning) stopwatch.Start();
		/*if (stopwatch.ElapsedMilliseconds > 100) {
			print(stopwatch.ElapsedMilliseconds + " - " + Environment.StackTrace);
		}*/
		if (stopwatch.ElapsedMilliseconds > 64)
			await WaitFrame();
	}

	// Use this for initialization
	async Task Start() {
		Settings.Mode mode = UnitySettings.GameMode;
		string gameDataBinFolder = UnitySettings.GameDirs.ContainsKey(mode) ? UnitySettings.GameDirs[mode] : "";
		string lvlPath = UnitySettings.SelectedLevelFile;
		string logFile = UnitySettings.LogFile;
		bool log = UnitySettings.Log;
		bool loadAnimations = UnitySettings.LoadAnimations;


#if UNITY_EDITOR
		if (Application.isEditor && UnityEditor.EditorUserBuildSettings.activeBuildTarget == UnityEditor.BuildTarget.WebGL) {
			FileSystem.mode = FileSystem.Mode.Web;
		}
#endif
		if (Application.platform == RuntimePlatform.WebGLPlayer) {
			FileSystem.mode = FileSystem.Mode.Web;
		}
		if (FileSystem.mode == FileSystem.Mode.Web) {
			gameDataBinFolder = UnitySettings.GameDirsWeb.ContainsKey(mode) ? UnitySettings.GameDirsWeb[mode] : "";
		}

		// Read command line arguments
		string[] args = Environment.GetCommandLineArgs();
		string modeString = "";
		for (int i = 0; i < args.Length; i++) {
			switch (args[i]) {
				case "--lvl":
				case "-l":
					lvlPath = args[i + 1];
					i++;
					break;
				case "--folder":
				case "--directory":
				case "-d":
				case "-f":
					gameDataBinFolder = args[i + 1];
					i++;
					break;
				case "--mode":
				case "-m":
					modeString = args[i + 1];
					i++;
					break;
			}
		}
		Application.logMessageReceived += Log;
		icons = Resources.LoadAll<Sprite>("tagicons");

		if (Application.platform == RuntimePlatform.WebGLPlayer) {
			//Application.logMessageReceived += communicator.WebLog;
			UnityEngine.Debug.unityLogger.logEnabled = false; // We don't need prints here
			string url = Application.absoluteURL;
			if (url.IndexOf('?') > 0) {
				string urlArgsStr = url.Split('?')[1].Split('#')[0];
				if (urlArgsStr.Length > 0) {
					string[] urlArgs = urlArgsStr.Split('&');
					foreach (string arg in urlArgs) {
						string[] argKeyVal = arg.Split('=');
						if (argKeyVal.Length > 1) {
							switch (argKeyVal[0]) {
								case "lvl":
									lvlPath = argKeyVal[1]; break;
								case "mode":
									modeString = argKeyVal[1]; break;
								case "folder":
								case "directory":
								case "dir":
									gameDataBinFolder = argKeyVal[1]; break;
							}
						}
					}
				}
			}
		}
		if (Settings.cmdModeNameDict.ContainsKey(modeString)) {
			mode = Settings.cmdModeNameDict[modeString];
		}
		loadingScreen.Active = true;
		Settings.Init(mode);
		loader = MapLoader.Loader;
		loader.gameDataBinFolder = gameDataBinFolder;
		loader.pathFolder = System.IO.Path.GetDirectoryName(lvlPath);
		loader.pathFile = System.IO.Path.GetFileName(lvlPath);
		//loader.lvlName = lvlName;
		loader.forceDisplayBackfaces = forceDisplayBackfaces;
		loader.baseMaterial = baseMaterial;
		loader.baseTransparentMaterial = baseTransparentMaterial;
		loader.collideMaterial = collideMaterial;
		loader.collideTransparentMaterial = collideTransparentMaterial;
		loader.baseLightMaterial = baseLightMaterial;
		loader.logFile = logFile;
		loader.logEnabled = log;
		loader.loadAnimations = loadAnimations;
		loader.controller = this;

		await Init();
	}

	async Task Init() {
		Stopwatch w = new Stopwatch();
		w.Start();
		LoadState = State.Loading;
		await Controller.WaitFrame();
		await loader.LoadInit();
		await Controller.WaitFrame();
		if (LoadState == State.Error) return;
		LoadState = State.Initializing;
		zListManager.Sort();
		print("Loading finished after " + w.ElapsedMilliseconds + "ms.");
		w.Stop();
		await Controller.WaitFrame();
		DetailedState = "Finished";
		LoadState = State.Finished;
		loadingScreen.Active = false;
	}

	public async Task LoadActor(Scene scene, string pathFile, string pathFolder) {
		LoadState = State.Loading;
		loadingScreen.Active = true;
		ContainerFile<Actor> act = await MapLoader.Loader.LoadExtraActor(pathFile, pathFolder);
		if (act != null && act.obj != null) {
			await Controller.WaitFrame();
			CSerializable c = await MapLoader.Loader.Clone(act.obj, "act");
			LoadState = State.Initializing;
			await scene.AddActor(c as Actor, pathFile.Substring(0, pathFile.IndexOf('.')));
			MapLoader.Loader.controller.zListManager.Sort();
			await Controller.WaitFrame();
		}
		DetailedState = "Finished";
		LoadState = State.Finished;
		loadingScreen.Active = false;
	}

	public async Task ExportActor(Actor actor, string path) {
		LoadState = State.Loading;
		loadingScreen.Active = true;
		await MapLoader.Loader.WriteActor(path, actor);
		DetailedState = "Finished";
		LoadState = State.Finished;
		loadingScreen.Active = false;
	}

	// Update is called once per frame
	void Update() {
		if (loadingScreen.Active) {
			if (LoadState == State.Error) {
				loadingScreen.LoadingText = DetailedState;
				loadingScreen.LoadingtextColor = UnityEngine.Color.red;
			} else {
				if (LoadState == State.Loading) {
					loadingScreen.LoadingText = loader.loadingState;
				} else {
					loadingScreen.LoadingText = DetailedState;
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
				if (LoadState != State.Finished) {
					// Allowed exceptions
					if (condition.Contains("cleaning the mesh failed")) break;

					// Go to error state
					LoadState = State.Error;
					if (loadingScreen.Active) {
						DetailedState = condition;
					}
				}
				break;
		}
	}

	public Sprite GetIcon(string name) {
		return icons.FirstOrDefault(s => s.name == name);
	}
}
