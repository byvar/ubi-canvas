using UnityEditor;
using UbiArt;
using UnityEngine;

public class UnityWindowActor : UnityWindow {
	[MenuItem("Ubi-Canvas/Actor Tools")]
	public static void ShowWindow() {
		GetWindow<UnityWindowActor>("Actor Tools");
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("Favorite");
		titleContent.text = "Actor Tools";
	}
	async void OnGUI() {
		float yPos = 0f;
		if (EditorApplication.isPlaying) {
			if (controller == null) controller = FindObjectOfType<Controller>();
			if (Controller.LoadState == Controller.State.Finished) {
				string extension = "act" + (Settings.s.cooked ? ".ckd" : "");
				if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
					extension = "act_fake";
				}
				#region Add Actor
				DrawHeader(ref yPos, "Add Actor");
				Rect rect = GetNextRect(ref yPos, vPaddingBottom: 4f);
				string buttonString = "No actor file selected";
				if (SelectedActorFile != null) {
					buttonString = System.IO.Path.GetFileName(SelectedActorFile);
				}
				rect = EditorGUI.PrefixLabel(rect, new GUIContent("Actor file"));
				if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
					string directory = (MapLoader.Loader.gameDataBinFolder + Settings.s.ITFDirectory).Replace(System.IO.Path.DirectorySeparatorChar, '/');
					if (!directory.EndsWith("/")) directory += "/";
					while (directory.Contains("//")) directory = directory.Replace("//", "/");

					if (recheckFiles || Dropdown == null || Dropdown.directory != directory || Dropdown.extension != "*." + extension || Dropdown.mode != Settings.s.mode) {
						Dropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState(), directory, "*." + extension) {
							name = "Actor files",
							mode = Settings.s.mode
						};
						recheckFiles = false;
					}
					Dropdown.Show(rect);
				}
				if (Dropdown != null && Dropdown.selection != null) {
					SelectedActorFile = Dropdown.selection;
					Dropdown.selection = null;
					Dirty = true;
				}
				if (!string.IsNullOrEmpty(SelectedActorFile)) {
					EditorGUI.TextArea(GetNextRect(ref yPos), SelectedActorFile);
				}
				EditorGUI.BeginDisabledGroup(string.IsNullOrEmpty(SelectedActorFile));
				UbiArt.ITF.Scene sc = MapLoader.Loader.mainScene.obj;
				UbiArt.ITF.SubSceneActor ssa = null;
				if (Selection.activeGameObject != null) {
					UnityScene us = Selection.activeGameObject.GetComponent<UnityScene>();
					if (us != null && us.scene != null) {
						sc = us.scene;
						ssa = us.subSceneActor;
					}
				}
				if (sc != null) {
					EditorGUI.LabelField(GetNextRect(ref yPos), new GUIContent("Selected scene"), new GUIContent(ssa == null ? "Main scene" : ssa.USERFRIENDLY));
				}

				if (GUI.Button(GetNextRect(ref yPos), new GUIContent("Load"))) {
					string pathFolder = System.IO.Path.GetDirectoryName(SelectedActorFile);
					string pathFile = System.IO.Path.GetFileName(SelectedActorFile);
					if (sc != null) {
						await controller.LoadActor(sc, pathFile, pathFolder);
					}
				}
				EditorGUI.EndDisabledGroup();
				#endregion

				#region Export Actor
				DrawHeader(ref yPos, "Export Actor");
				UbiArt.ITF.Actor a = null;
				if (Selection.activeGameObject != null) {
					UnityPickable up = Selection.activeGameObject.GetComponent<UnityPickable>();
					if (up != null && up.pickable != null && up.pickable.GetType() == typeof(UbiArt.ITF.Actor)) {
						a = up.pickable as UbiArt.ITF.Actor;
					}
				}
				EditorGUI.LabelField(GetNextRect(ref yPos), new GUIContent("Selected actor"), new GUIContent(a == null ? "None" : a.USERFRIENDLY));
				ActorPath = FileField(GetNextRect(ref yPos), "Actor path", ActorPath, true, extension);

				EditorGUI.BeginDisabledGroup(a == null || string.IsNullOrEmpty(ActorPath));
				if (GUI.Button(GetNextRect(ref yPos), new GUIContent("Export"))) {
					await controller.ExportActor(a, ActorPath);
					recheckFiles = true;
				}
				EditorGUI.EndDisabledGroup();
				#endregion
			} else {
				EditorGUILayout.HelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorGUILayout.HelpBox("Please start the scene to use this window.", MessageType.Info);
		}
	}

	private Controller controller;

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown Dropdown { get; set; }

	/// <summary>
	/// The selected actor file
	/// </summary>
	private string SelectedActorFile { get; set; }

	/// <summary>
	/// The selected actor file
	/// </summary>
	private string ActorPath { get; set; }

	private bool recheckFiles = false;
}