using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiCanvas.Helpers;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using System.Linq;
using UbiArt.ITF;

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
				string ExtensionActor = c.Settings.EngineVersion == EngineVersion.RO ? "uca" : "act";
				string ExtensionActorTemplate = c.Settings.EngineVersion == EngineVersion.RO ? "act" : "tpl";
				string ExtensionTemplateScene = "tsc";
				string ExtensionScene = "isc";
				string ExtensionFrise = "frz";
				//string ExtensionFriseConfig = $"*.fcg{(c.Settings.Cooked ? ".ckd" : "")}";
				string ExtensionSubSceneActor = $"ucs";

				string[] extensions = new string[] {
					$"*.{ExtensionActor}{(c.Settings.Cooked ? ".ckd" : "")}",
					$"*.{ExtensionActorTemplate}{(c.Settings.Cooked ? ".ckd" : "")}",
					$"*.{ExtensionTemplateScene}{(c.Settings.Cooked ? ".ckd" : "")}",
					//$"*.{ExtensionScene}{(c.Settings.Cooked ? ".ckd" : "")}",
					$"*.{ExtensionFrise}{(c.Settings.Cooked ? ".ckd" : "")}",
					$"*.{ExtensionSubSceneActor}{(c.Settings.Cooked ? ".ckd" : "")}"
				};
				#region Add Actor
				DrawHeader("Import Actor");
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
					UbiArt.Path path = new Path(pathFolder, pathFile);
					var extension = path.GetExtension(removeCooked: true).ToLowerInvariant();
					if (sc != null) {
						if (extension == ExtensionActorTemplate) {
							ExecuteTask(
								controller.AdditionalLoad(controller.LoadTemplateAndCreateActor(sc, path).AsTask())
							);
						} else if (extension == ExtensionActor) {
							ExecuteTask(controller.AdditionalLoad(controller.LoadActorContainer<Actor>(sc, path).AsTask()));
						} else if (extension == ExtensionFrise) {
							ExecuteTask(controller.AdditionalLoad(controller.LoadActorContainer<Frise>(sc, path).AsTask()));
						} else if (extension == ExtensionSubSceneActor) {
							ExecuteTask(controller.AdditionalLoad(controller.LoadActorContainer<SubSceneActor>(sc, path).AsTask()));
						} else if (extension == ExtensionTemplateScene || extension == ExtensionScene) {
							ExecuteTask(controller.AdditionalLoad(controller.LoadActorContainer<Scene>(sc, path).AsTask()));
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
					if (up?.pickable != null && up.pickable is Actor act) {
						a = act;
					}
				}
				EditorGUI.LabelField(GetNextRect(), new GUIContent("Selected actor"), new GUIContent(a == null ? "None" : a.USERFRIENDLY));
				var chosenExtension = ExtensionActor;
				if (a is Frise f) {
					chosenExtension = ExtensionFrise;
				} else if (a is SubSceneActor s) {
					chosenExtension = ExtensionSubSceneActor;
				}
				if (c.Settings.Cooked) {
					chosenExtension += ".ckd";
				}
				ActorPath = FileField(GetNextRect(), "Actor path", ActorPath, true, chosenExtension);

				EditorGUI.BeginDisabledGroup(a == null || string.IsNullOrEmpty(ActorPath));
				if (EditorButton("Export")) {
					async UniTask exportActor() {
						await controller.ExportActorContainer(a, ActorPath);
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