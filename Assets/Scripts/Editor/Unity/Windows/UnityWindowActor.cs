using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiCanvas.Helpers;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using System.Linq;

public class UnityWindowActor : UnityWindow {
	[MenuItem("Ubi-Canvas/Actor Tools")]
	public static void ShowWindow() {
		GetWindow<UnityWindowActor>("Actor Tools");
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("Favorite");
		titleContent.text = "Actor Tools";
	}
	protected override void UpdateEditorFields() {
		base.UpdateEditorFields();
		if (EditorApplication.isPlaying) {
			if (controller == null) controller = Controller.Obj;
			if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
				var c = Controller.MainContext;
				string[] extensions = new string[] { $"*.act{(c.Settings.Cooked ? ".ckd" : "")}", $"*.tpl{(c.Settings.Cooked ? ".ckd" : "")}" };
				if (c.Settings.EngineVersion == EngineVersion.RO) {
					extensions = new string[] { $"*.act{(c.Settings.Cooked ? ".ckd" : "")}", "*.act_fake" };
				}
				#region Add Actor
				DrawHeader("Add Actor");
				Rect rect = GetNextRect(vPaddingBottom: 4f);
				string buttonString = "No actor file selected";
				if (SelectedActorFile != null) {
					buttonString = System.IO.Path.GetFileName(SelectedActorFile);
				}
				rect = EditorGUI.PrefixLabel(rect, new GUIContent("Actor file"));
				if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
					string directory = (Controller.MainContext.BasePath + c.Settings.ITFDirectory).Replace(System.IO.Path.DirectorySeparatorChar, '/');
					if (!directory.EndsWith("/")) directory += "/";
					while (directory.Contains("//")) directory = directory.Replace("//", "/");

					if (recheckFiles || Dropdown == null || Dropdown.directory != directory || Dropdown.extensions == null || !Enumerable.SequenceEqual(Dropdown.extensions, extensions) || Dropdown.mode != c.Settings.Mode) {
						Dropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState(), directory, extensions) {
							name = "Actor files",
							mode = c.Settings.Mode
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
					EditorGUI.TextArea(GetNextRect(), SelectedActorFile);
				}
				EditorGUI.BeginDisabledGroup(string.IsNullOrEmpty(SelectedActorFile));
				UbiArt.ITF.Scene sc = Controller.Obj.MainScene.obj;
				UbiArt.ITF.SubSceneActor ssa = null;
				if (Selection.activeGameObject != null) {
					UnityScene us = Selection.activeGameObject.GetComponent<UnityScene>();
					if (us != null && us.scene != null) {
						sc = us.scene;
						ssa = us.subSceneActor;
					}
				}
				if (sc != null) {
					EditorGUI.LabelField(GetNextRect(), new GUIContent("Selected scene"), new GUIContent(ssa == null ? "Main scene" : ssa.USERFRIENDLY));
				}

				if (EditorButton("Load")) {
					string pathFolder = System.IO.Path.GetDirectoryName(SelectedActorFile);
					string pathFile = System.IO.Path.GetFileName(SelectedActorFile);
					if (sc != null) {
						if (c.Settings.EngineVersion == EngineVersion.RO && !pathFile.ToLowerInvariant().EndsWith(".act_fake")
							|| pathFile.ToLowerInvariant().EndsWith($".tpl{(c.Settings.Cooked ? ".ckd" : "")}")) {
							ExecuteTask(
								controller.AdditionalLoad(controller.LoadTemplateAndCreateActor(sc, pathFile, pathFolder).AsTask())
							);
						} else {
							ExecuteTask(controller.AdditionalLoad(controller.LoadActor(sc, pathFile, pathFolder).AsTask()));
						}
					}
				}
				EditorGUI.EndDisabledGroup();
				#endregion

				#region Export Actor
				DrawHeader("Export Actor");
				UbiArt.ITF.Actor a = null;
				if (Selection.activeGameObject != null) {
					UnityPickable up = Selection.activeGameObject.GetComponent<UnityPickable>();
					if (up != null && up.pickable != null && up.pickable.GetType() == typeof(UbiArt.ITF.Actor)) {
						a = up.pickable as UbiArt.ITF.Actor;
					}
				}
				EditorGUI.LabelField(GetNextRect(), new GUIContent("Selected actor"), new GUIContent(a == null ? "None" : a.USERFRIENDLY));
				ActorPath = FileField(GetNextRect(), "Actor path", ActorPath, true, extensions[0].Substring(2));

				EditorGUI.BeginDisabledGroup(a == null || string.IsNullOrEmpty(ActorPath));
				if (EditorButton("Export")) {
					async UniTask exportActor() {
						await controller.ExportActor(a, ActorPath);
						recheckFiles = true;
					};
					ExecuteTask(exportActor());
				}
				EditorGUI.EndDisabledGroup();
				#endregion
			} else {
				EditorHelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorHelpBox("Please start the scene to use this window.", MessageType.Info);
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