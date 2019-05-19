using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiArt.ITF;

public class UnityAddActorWindow : EditorWindow {
	string pathFolder;
	string pathFile;

	[MenuItem("Window/Add Actor")]
	public static void ShowWindow() {
		GetWindow<UnityAddActorWindow>("Add actor");
	}

	async void OnGUI() {
		GUILayout.Label("Add actor", EditorStyles.boldLabel);
		pathFolder = EditorGUILayout.TextField("Folder", pathFolder);
		pathFile   = EditorGUILayout.TextField("File",   pathFile);
		if (GUILayout.Button("Load")) {
			Scene sc = MapLoader.Loader.mainScene.obj;
			if (Selection.activeGameObject != null) {
				UnityScene us = Selection.activeGameObject.GetComponent<UnityScene>();
				if (us != null && us.scene != null) sc = us.scene;
			}
			if (sc != null) {
				await FindObjectOfType<Controller>().LoadActor(sc, pathFile, pathFolder);
			}
		}
	}
}