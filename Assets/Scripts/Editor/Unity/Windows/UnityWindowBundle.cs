using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiArt.ITF;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;
using UbiCanvas;
using System.Linq;
using UbiCanvas.Conversion;

public class UnityWindowBundle : UnityWindow {
	[MenuItem("Ubi-Canvas/Bundle Export")]
	public static void ShowWindow() {
		GetWindow<UnityWindowBundle>("Bundle Export");
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("SaveActive");
		titleContent.text = "Bundle Export";
	}
	protected override void UpdateEditorFields() {
		base.UpdateEditorFields();
		if (EditorApplication.isPlaying) {
			if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
				EditorGUI.BeginChangeCheck();

				DrawHeader("Export Game Data");

				UnitySettings.Export_UseRaw = EditorField($"Export raw files", UnitySettings.Export_UseRaw);
				if (UnitySettings.Export_UseRaw) {
					UnitySettings.Export_OutputPathFolder = DirectoryField(GetNextRect(), "Mod folder", UnitySettings.Export_OutputPathFolder, true);
				} else {
					UnitySettings.Export_OutputPathFile = FileField(GetNextRect(), "Bundle file", UnitySettings.Export_OutputPathFile, true, "ipk");
				}

				EditorHelpBox("Please make sure to only export files you've modified. Usually this should only be the scene file.\n" +
					"Be aware that changes to most other files such as actor templates will affect the entire game - not just this level.", MessageType.Info, padding: 10);

				Loader l = Controller.MainContext.Loader;
				DrawFoldout("Scenes", l.isc);
				DrawFoldout("Generic", l.isg);
				//DrawFoldout("Actors", l.act);
				DrawFoldout("Frise Config", l.fcg);
				DrawFoldout("Actor Templates", l.tpl);
				bool canExport = false;
				if(UnitySettings.Export_UseRaw)
					canExport = !string.IsNullOrEmpty(UnitySettings.Export_OutputPathFolder);
				else
					canExport = !string.IsNullOrEmpty(UnitySettings.Export_OutputPathFile);
				EditorGUI.BeginDisabledGroup(!canExport);
				if (EditorButton("Write")) {
					List<pair<Path, ICSerializable>> selection = new List<pair<Path, ICSerializable>>();
					GetSelectedPaths(selection, l.isc);
					GetSelectedPaths(selection, l.isg);
					//GetSelectedPaths(selection, l.act);
					GetSelectedPaths(selection, l.fcg);
					GetSelectedPaths(selection, l.tpl);

					async UniTask writeBundle() {
						using (Controller.MainContext) {
							if (UnitySettings.Export_UseRaw)
								await l.WriteFilesRaw(UnitySettings.Export_OutputPathFolder, selection);
							else
								await l.WriteBundle(UnitySettings.Export_OutputPathFile, selection);
						}
					}
					ExecuteTask(writeBundle());
				}
				EditorGUI.EndDisabledGroup();

				if (EditorGUI.EndChangeCheck()) {
					UnitySettings.Save();
				}
			} else {
				EditorHelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorHelpBox("Please start the scene to use this window.", MessageType.Info);
		}
	}

	void DrawFoldout<T>(string title, Dictionary<StringID, T> dict) where T : ICSerializable {
		if(dict == null)
			return;
		if (!foldouts.ContainsKey(title)) {
			foldouts[title] = false;
		}
		foldouts[title] = EditorGUI.Foldout(GetNextRect(), foldouts[title], title, true);
		//foldouts[title] = EditorGUILayout.Foldout(foldouts[title], title, true);
		if (foldouts[title]) {
			Loader l = Controller.MainContext.Loader;

			bool selectAll = EditorButton("Select all");

			foreach (StringID sid in dict.Keys) {
				if (!selectedPaths.ContainsKey(sid)) {
					selectedPaths[sid] = false;
				}
				selectedPaths[sid] = EditorGUI.ToggleLeft(GetNextRect(), l.Paths[sid].FullPath, selectedPaths[sid] || selectAll);
			}
		}
	}
	void GetSelectedPaths<T>(List<pair<Path, ICSerializable>> selection, Dictionary<StringID, T> dict) where T : ICSerializable {
		Loader l = Controller.MainContext.Loader;
		if(dict == null) return;
		foreach (StringID sid in dict.Keys) {
			if (!selectedPaths.ContainsKey(sid)) continue;
			if (selectedPaths[sid]) {
				selection.Add(new pair<Path, ICSerializable>(l.Paths[sid], dict[sid]));
			}
		}
	}

	private Dictionary<string, bool> foldouts = new Dictionary<string, bool>();
	private Dictionary<StringID, bool> selectedPaths = new Dictionary<StringID, bool>();
}