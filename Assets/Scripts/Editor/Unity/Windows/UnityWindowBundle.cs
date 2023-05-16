﻿using UnityEditor;
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
					List<pair<Path, ICSerializable>> selection = new List<pair<Path, ICSerializable>>();
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
					await new AdventuresToLegendsConverter().Convert(Controller.MainContext, rlPath, path);
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

	private float totalyPos = 0f;
	private Vector2 scrollPosition = Vector2.zero;
	private string path;
	private string rlPath;
	private Dictionary<string, bool> foldouts = new Dictionary<string, bool>();
	private Dictionary<StringID, bool> selectedPaths = new Dictionary<StringID, bool>();
}