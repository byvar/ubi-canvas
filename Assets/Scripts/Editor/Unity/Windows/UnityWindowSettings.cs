using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UbiArt;
using UbiCanvas.Helpers;
using UnityEditor;
using UnityEngine;
using Path = System.IO.Path;

public class UnityWindowSettings : UnityWindow {
	#region Unity Methods
	[MenuItem("Ubi-Canvas/Settings")]
	public static void ShowWindow() {
		GetWindow<UnityWindowSettings>(false, "Settings", true);
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("Settings");
		titleContent.text = "Settings";
	}
	protected override void UpdateEditorFields() {
		base.UpdateEditorFields();
		FileSystem.Mode fileMode = FileSystem.Mode.Normal;
		if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.WebGL) {
			fileMode = FileSystem.Mode.Web;
		}

		// Increase label width due to it being cut off otherwise
		EditorGUIUtility.labelWidth = 180;
		
		EditorGUI.BeginChangeCheck();
		// Game Mode
		DrawHeader("Mode");
		UnitySettings.GameMode = EditorField<Settings.Mode>("Game", UnitySettings.GameMode);


		// Scene file
		DrawHeader("Scene file");

		string buttonString = "No level file selected";
		if (UnitySettings.SelectedLevelFile != null) {
			buttonString = Path.GetFileName(UnitySettings.SelectedLevelFile);
		}
		Rect rect = GetNextRect(vPaddingBottom: 4f);
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Selected file"));
		if (fileMode == FileSystem.Mode.Web) {
			UnitySettings.SelectedLevelFile = EditorGUI.TextField(rect, UnitySettings.SelectedLevelFile);
			EditorHelpBox("Your build target is configured as WebGL. Ubi-Canvas will attempt to load from the server. Make sure the caps in the map name are correct.", MessageType.Warning);
		} else {
			if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
				// Initialize settings
				var s = Settings.Init(UnitySettings.GameMode);
				string directory = (CurrentGameDataDir + "/" + s.ITFDirectory).Replace(Path.DirectorySeparatorChar, '/');
				if (!directory.EndsWith("/")) directory += "/";
				while (directory.Contains("//")) directory = directory.Replace("//", "/");
				string extension = "*.isc";
				if (s.cooked) {
					extension += ".ckd";
				}

				if (Dropdown == null || Dropdown.directory != directory || Dropdown.extension != extension || Dropdown.mode != UnitySettings.GameMode) {
					Dropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState(), directory, extension) {
						name = "Scene files",
						mode = UnitySettings.GameMode
					};
				}
				Dropdown.Show(rect);
			}
		}
		if (Dropdown != null && Dropdown.selection != null) {
			UnitySettings.SelectedLevelFile = Dropdown.selection;
			Dropdown.selection = null;
			Dirty = true;
		}
		if (UnitySettings.SelectedLevelFile != null) {
			EditorGUI.TextArea(GetNextRect(), UnitySettings.SelectedLevelFile);
		}

		// Directories
		DrawHeader("Directories" + (fileMode == FileSystem.Mode.Web ? " (Web)" : ""));
		Settings.Mode[] modes = (Settings.Mode[])Enum.GetValues(typeof(Settings.Mode));
		if (fileMode == FileSystem.Mode.Web) {
			foreach (Settings.Mode mode in modes) {
				UnitySettings.GameDirsWeb[mode] = EditorField(mode.GetDescription(), UnitySettings.GameDirsWeb.ContainsKey(mode) ? UnitySettings.GameDirsWeb[mode] : "");
			}
		} else {
			foreach (Settings.Mode mode in modes) {
				UnitySettings.GameDirs[mode] = DirectoryField(GetNextRect(), mode.GetDescription(), UnitySettings.GameDirs.ContainsKey(mode) ? UnitySettings.GameDirs[mode] : "");
			}
		}
		/*if (GUILayout.Button("Update available scenes")) {
			string path = EditorUtility.OpenFilePanel("Scene files", "", "isc.ckd");
			if (path.Length != 0) {
				//UbiCanvasSettings.SelectedLevelFile = AvailableFiles.ElementAtOrDefault(SelectedLevelFileIndex);
			}
		}*/

		// Misc
		DrawHeader("Miscellaneous Settings");
		rect = GetNextRect();
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Serialization Log"));
		bool log = UnitySettings.Log;
		rect = PrefixToggle(rect, ref log);
		UnitySettings.Log = log;
		if (UnitySettings.Log) {
			UnitySettings.LogFile = FileField(rect, "Serialization Log File", UnitySettings.LogFile, true, "txt", includeLabel: false);
		}

		UnitySettings.LoadAnimations = EditorField("Load Animations", UnitySettings.LoadAnimations);
		UnitySettings.LoadAllPaths = EditorField("Load all paths", UnitySettings.LoadAllPaths);

		if (EditorGUI.EndChangeCheck() || Dirty) {
			UnitySettings.Save();
			Dirty = false;
		}
	}
	#endregion

	#region Properties

	/// <summary>
	/// The selected level file index, based on <see cref="AvailableFiles"/>
	/// </summary>
	private int SelectedLevelFileIndex { get; set; }

	/// <summary>
	/// Copy of the previous game data folder for reference
	/// </summary>
	private string PreviousGameDataFolder { get; set; }

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown Dropdown { get; set; }

	private string CurrentGameDataDir {
		get {
			Dictionary<Settings.Mode, string> GameDirs =
				EditorUserBuildSettings.activeBuildTarget == BuildTarget.WebGL ? UnitySettings.GameDirsWeb : UnitySettings.GameDirs;
			if (GameDirs.ContainsKey(UnitySettings.GameMode)) {
				return (GameDirs[UnitySettings.GameMode] ?? "");
			} else {
				return "";
			}
		}
	}
	#endregion
}