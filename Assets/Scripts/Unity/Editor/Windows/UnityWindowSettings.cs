using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UbiArt;
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
	public void OnGUI() {
		// Increase label width due to it being cut off otherwise
		EditorGUIUtility.labelWidth = 180;

		float yPos = 0f;
		EditorGUI.BeginChangeCheck();
		// Game Mode
		DrawHeader(ref yPos, "Mode");
		UnitySettings.GameMode = (Settings.Mode)EditorGUI.EnumPopup(GetNextRect(ref yPos), new GUIContent("Game"), UnitySettings.GameMode);

		// Directories
		DrawHeader(ref yPos, "Directories");
		UnitySettings.ROGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Origins (PC)", UnitySettings.ROGameDataDir);
		UnitySettings.RLGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Legends (PC)", UnitySettings.RLGameDataDir);
		UnitySettings.RLVitaGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Legends (PSV)", UnitySettings.RLVitaGameDataDir);
		UnitySettings.RAGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Adventures (Android)", UnitySettings.RAGameDataDir);

		/*if (GUILayout.Button("Update available scenes")) {
			string path = EditorUtility.OpenFilePanel("Scene files", "", "isc.ckd");
			if (path.Length != 0) {
				//UbiCanvasSettings.SelectedLevelFile = AvailableFiles.ElementAtOrDefault(SelectedLevelFileIndex);
			}
		}*/
		// Scene file
		DrawHeader(ref yPos, "Scene file");

		string buttonString = "No level file selected";
		if (UnitySettings.SelectedLevelFile != null) {
			buttonString = Path.GetFileName(UnitySettings.SelectedLevelFile);
		}
		Rect rect = GetNextRect(ref yPos, vPaddingBottom: 4f);
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Selected file"));
		if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
			// Initialize settings
			Settings.Init(UnitySettings.GameMode);
			string directory = (UnitySettings.CurrentGameDataDir + "/" + Settings.s.ITFDirectory).Replace(Path.DirectorySeparatorChar, '/');
			if (!directory.EndsWith("/")) directory += "/";
			while (directory.Contains("//")) directory = directory.Replace("//", "/");
			string extension = "*.isc";
			if (Settings.s.cooked) {
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
		if (Dropdown != null && Dropdown.selection != null) {
			UnitySettings.SelectedLevelFile = Dropdown.selection;
			Dropdown.selection = null;
			Dirty = true;
		}
		if (UnitySettings.SelectedLevelFile != null) {
			EditorGUI.TextArea(GetNextRect(ref yPos), UnitySettings.SelectedLevelFile);
		}

		// Misc
		DrawHeader(ref yPos, "Miscellaneous Settings");
		rect = GetNextRect(ref yPos);
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Serialization Log"));
		bool log = UnitySettings.Log;
		rect = PrefixToggle(rect, ref log);
		UnitySettings.Log = log;
		if (UnitySettings.Log) {
			UnitySettings.LogFile = FileField(rect, "Serialization Log File", UnitySettings.LogFile, true, "txt", includeLabel: false);
		}

		UnitySettings.LoadAnimations = EditorGUI.Toggle(GetNextRect(ref yPos), new GUIContent("Load Animations"), UnitySettings.LoadAnimations);

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

	#endregion
}