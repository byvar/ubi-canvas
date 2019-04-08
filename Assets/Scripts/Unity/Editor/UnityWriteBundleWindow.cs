using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiArt.ITF;
using System.Collections.Generic;

public class UnityWriteBundleWindow : EditorWindow {
	string path;
	Dictionary<string, bool> foldouts = new Dictionary<string, bool>();
	Dictionary<StringID, bool> selectedPaths = new Dictionary<StringID, bool>();

	[MenuItem("Window/Write Bundle")]
	public static void ShowWindow() {
		GetWindow<UnityWriteBundleWindow>("Write bundle");
	}

	async void OnGUI() {
		GUILayout.Label("Write bundle", EditorStyles.boldLabel);
		path = EditorGUILayout.TextField("Bundle path", path);
		Controller controller = FindObjectOfType<Controller>();
		if (controller != null && controller.LoadState == Controller.State.Finished) {
			MapLoader l = MapLoader.Loader;
			DrawFoldout("Scenes", l.isc);
			DrawFoldout("Generic", l.isg);
			//DrawFoldout("Actors", l.act);
			DrawFoldout("Frise Config", l.fcg);
			DrawFoldout("Actor Templates", l.tpl);
			if (GUILayout.Button("Write")) {
				List<Pair<Path, ICSerializable>> selection = new List<Pair<Path, ICSerializable>>();
				GetSelectedPaths(selection, l.isc);
				GetSelectedPaths(selection, l.isg);
				//GetSelectedPaths(selection, l.act);
				GetSelectedPaths(selection, l.fcg);
				GetSelectedPaths(selection, l.tpl);
				await MapLoader.Loader.WriteBundle(path,selection);
			}
		}
		
	}

	void DrawFoldout<T>(string title, Dictionary<StringID, T> dict) where T : ICSerializable {
		if (!foldouts.ContainsKey(title)) {
			foldouts[title] = false;
		}
		foldouts[title] = EditorGUILayout.Foldout(foldouts[title], title, true);
		if (foldouts[title]) {
			MapLoader l = MapLoader.Loader;
			foreach (StringID sid in dict.Keys) {
				if (!selectedPaths.ContainsKey(sid)) {
					selectedPaths[sid] = false;
				}
				selectedPaths[sid] = EditorGUILayout.ToggleLeft(l.paths[sid].FullPath, selectedPaths[sid]);
			}
		}
	}
	void GetSelectedPaths<T>(List<Pair<Path, ICSerializable>> selection, Dictionary<StringID, T> dict) where T : ICSerializable {
		MapLoader l = MapLoader.Loader;
		foreach (StringID sid in dict.Keys) {
			if (!selectedPaths.ContainsKey(sid)) continue;
			if (selectedPaths[sid]) {
				selection.Add(new Pair<Path, ICSerializable>(l.paths[sid], dict[sid]));
			}
		}
	}
}