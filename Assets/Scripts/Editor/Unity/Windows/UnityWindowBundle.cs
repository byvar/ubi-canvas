using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiArt.ITF;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;
using UbiCanvas;

public class UnityWindowBundle : UnityWindow {
	[MenuItem("Ubi-Canvas/Bundle Export")]
	public static void ShowWindow() {
		GetWindow<UnityWindowBundle>("Bundle Export");
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("SaveActive");
		titleContent.text = "Bundle Export";
	}
	async void OnGUI() {
		float yPos = 0f;
		if (EditorApplication.isPlaying) {
			if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
				if (totalyPos == 0f) totalyPos = position.height;
				scrollbarShown = totalyPos > position.height;
				scrollPosition = GUI.BeginScrollView(new Rect(0,0, EditorGUIUtility.currentViewWidth, position.height), scrollPosition, new Rect(0, 0, EditorGUIUtility.currentViewWidth - (scrollbarShown ? scrollbarWidth : 0f), totalyPos));
				DrawHeader(ref yPos, "Export Patch Bundle");
				path = FileField(GetNextRect(ref yPos), "Bundle file", path, true, "ipk");

				Loader l = Controller.MainContext.Loader;
				DrawFoldout(ref yPos, "Scenes", l.isc);
				DrawFoldout(ref yPos, "Generic", l.isg);
				//DrawFoldout("Actors", l.act);
				DrawFoldout(ref yPos, "Frise Config", l.fcg);
				DrawFoldout(ref yPos, "Actor Templates", l.tpl);
				EditorGUI.BeginDisabledGroup(string.IsNullOrEmpty(path));
				if (GUI.Button(GetNextRect(ref yPos), new GUIContent("Write"))) {
					List<Pair<Path, ICSerializable>> selection = new List<Pair<Path, ICSerializable>>();
					GetSelectedPaths(selection, l.isc);
					GetSelectedPaths(selection, l.isg);
					//GetSelectedPaths(selection, l.act);
					GetSelectedPaths(selection, l.fcg);
					GetSelectedPaths(selection, l.tpl);
					using (Controller.MainContext) 
						await l.WriteBundle(path, selection);
				}
				DrawHeader(ref yPos, "Rayman Legends Export");
				rlPath = FileField(GetNextRect(ref yPos), "Original bundle file", rlPath, false, "ipk");
				if (GUI.Button(GetNextRect(ref yPos), new GUIContent("Write all for RL"))) {
					var basePath = System.IO.Path.GetDirectoryName(rlPath);
					var settings = Settings.Init(Settings.Mode.RaymanLegendsPC);
					var mainContext = Controller.MainContext;

					// Step 1: create new paths dictionary
					var ogDir = l.Settings.ITFDirectory;
					var newDir = settings.ITFDirectory;
					var structs = l.Context.Cache.Structs;
					var pathMapping = new Dictionary<StringID, Path>();
					foreach (var structType in structs) {
						foreach (var structMap in structType.Value) {
							var ogPath = l.CookedPaths[structMap.Key];
							if (ogPath.folder != null && ogPath.folder.Contains(ogDir)) {
								pathMapping[structMap.Key] = new Path(ogPath.FullPath.Replace(ogDir, newDir), true);
							} else {
								pathMapping[structMap.Key] = ogPath;
							}
						}
					}
					// Step 2, load uv atlas manager, and combine with adventures. Write patch_PC
					/*UbiArt.UV.UVAtlasManager uvManager = null;
					using (var rlContextExt = new Context(UnitySettings.GameDirs[Settings.Mode.RaymanLegendsPC],
						Settings.Init(Settings.Mode.RaymanLegendsPC),
						fileManager: new MapViewerFileManager(),
						systemLogger: new UnitySystemLogger(),
						asyncController: new UniTaskAsyncController())) {
						await rlContextExt.Loader.LoadInitial();
						uvManager = rlContextExt.Loader.uvAtlasManager;
						foreach (var uv in l.uvAtlasManager.atlas) {
							if(!uvManager.atlas.ContainsKey(uv.Key)) uvManager.atlas.Add(uv);
						}
						await rlContextExt.Loader.WriteBundle(System.IO.Path.Combine(basePath, "patch_PC.ipk"), new List<Pair<Path, ICSerializable>>() {
							new Pair<Path, ICSerializable>(
								rlContextExt.Loader.CookedPaths[new Path("", "atlascontainer.ckd").stringID],
								uvManager)
						});
					}*/
					// Step 2, load replacement texture
					/*TextureCooked tempTexture = null;
					using (var rlContextExt = new Context(UnitySettings.GameDirs[Settings.Mode.RaymanLegendsPC],
						Settings.Init(Settings.Mode.RaymanLegendsPC),
						fileManager: new MapViewerFileManager(),
						systemLogger: new UnitySystemLogger(),
						asyncController: new UniTaskAsyncController())) {
						await rlContextExt.Loader.LoadInitial();
						rlContextExt.Loader.LoadTexture(new Path("world/common/playablecharacter/teensy/animation/teensy_a1.tga"), tex => {
							tempTexture = tex;
						});
						await rlContextExt.Loader.LoadLoop();
					}*/
					// Step 3, load bundles, for each struct check if it's already present in the bundle, otherwise add it
					using (var rlContext = new Context(basePath, settings,
						fileManager: new MapViewerFileManager(),
						systemLogger: new UnitySystemLogger(),
						asyncController: new UniTaskAsyncController())) {
						await rlContext.Loader.LoadBundles();
						var bun = new UbiArt.Bundle.BundleFile();
						var ogBun = rlContext.Loader.Bundles["Bundle"];

						// Add all original files to new bundle
						/*foreach (var f in ogBun.packMaster.files) {
							var fData = await ogBun.GetFile(rlContext, rlContext.Loader.BigFiles["Bundle"].Deserializer, f.Item2);
							bun.AddFile(f.Item2, fData);
						}*/
						// Add new data
						foreach (var structType in structs) {
							foreach (var structMap in structType.Value) {
								var curPath = pathMapping[structMap.Key];
								if(curPath.filename == "localisation.loc8") continue;
								//if (!bun.HasPreprocessedFile(curPath)) {
								if (!rlContext.Loader.AnyBundleContainsFile(curPath)) {
									/*if (structMap.Value is TextureCooked) {
										bun.AddFile(curPath, tempTexture);
									} else {*/
										bun.AddFile(curPath, structMap.Value);
									//}
								}
							}
						}
						// Write bundle
						await rlContext.Loader.WriteBundle(path, bun);
					}
				}
				EditorGUI.EndDisabledGroup();
				totalyPos = yPos;
				GUI.EndScrollView();
			} else {
				EditorGUILayout.HelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorGUILayout.HelpBox("Please start the scene to use this window.", MessageType.Info);
		}
	}

	void DrawFoldout<T>(ref float yPos, string title, Dictionary<StringID, T> dict) where T : ICSerializable {
		if(dict == null)
			return;
		if (!foldouts.ContainsKey(title)) {
			foldouts[title] = false;
		}
		foldouts[title] = EditorGUI.Foldout(GetNextRect(ref yPos), foldouts[title], title, true);
		//foldouts[title] = EditorGUILayout.Foldout(foldouts[title], title, true);
		if (foldouts[title]) {
			Loader l = Controller.MainContext.Loader;
			foreach (StringID sid in dict.Keys) {
				if (!selectedPaths.ContainsKey(sid)) {
					selectedPaths[sid] = false;
				}
				selectedPaths[sid] = EditorGUI.ToggleLeft(GetNextRect(ref yPos), l.Paths[sid].FullPath, selectedPaths[sid]);
			}
		}
	}
	void GetSelectedPaths<T>(List<Pair<Path, ICSerializable>> selection, Dictionary<StringID, T> dict) where T : ICSerializable {
		Loader l = Controller.MainContext.Loader;
		if(dict == null) return;
		foreach (StringID sid in dict.Keys) {
			if (!selectedPaths.ContainsKey(sid)) continue;
			if (selectedPaths[sid]) {
				selection.Add(new Pair<Path, ICSerializable>(l.Paths[sid], dict[sid]));
			}
		}
	}

	private float totalyPos = 0f;
	private Vector2 scrollPosition = Vector2.zero;
	private string path;
	private string rlPath;
	private Dictionary<string, bool> foldouts = new Dictionary<string, bool>();
	private Dictionary<StringID, bool> selectedPaths = new Dictionary<StringID, bool>();
}