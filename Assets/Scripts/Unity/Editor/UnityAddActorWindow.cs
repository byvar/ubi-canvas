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
			if (Selection.activeGameObject != null) {
				UnityScene us = Selection.activeGameObject.GetComponent<UnityScene>();
				if (us != null && us.scene != null) {
					ContainerFile<Actor> act = await MapLoader.Loader.LoadExtraActor(pathFile, pathFolder);
					if (act != null && act.obj != null) {
						CSerializable c = await MapLoader.Loader.Clone(act.obj, "act");
						us.scene.AddActor(c as Actor, pathFile.Substring(0, pathFile.IndexOf('.')));
						MapLoader.Loader.controller.zListManager.Sort();
					}
				}
			}
		}
	}
}