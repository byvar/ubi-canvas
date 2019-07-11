using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UbiArt;
using UnityEditor;
using UnityEngine;
using Path = System.IO.Path;

public class UbiCanvasSettingsWindow : EditorWindow {
	#region Unity Methods

	[MenuItem("Ubi-Canvas/Ubi-Canvas Setup")]
	public static void ShowWindow() {
		GetWindow<UbiCanvasSettingsWindow>(false, "Ubi-Canvas Setup", true);
	}

	private Rect GetNextRect(ref float yPos, float padding = 4f, float height = 0f, float vPadding = 0f, float vPaddingBottom = 0f) {
		if (height == 0f) height = EditorGUIUtility.singleLineHeight;
		Rect rect = new Rect(padding, yPos + vPadding, Mathf.Max(0f, EditorGUIUtility.currentViewWidth - padding*2f), height);
		yPos += height + vPadding * 2f + vPaddingBottom;
		return rect;
	}

	public void OnGUI() {
		// Increase label width due to it being cut off otherwise
		EditorGUIUtility.labelWidth = 180;

		float yPos = 0f;
		EditorGUI.BeginChangeCheck();
		// Game Mode
		DrawHeader(ref yPos, "Mode");
		UbiCanvasSettings.GameMode = (Settings.Mode)EditorGUI.EnumPopup(GetNextRect(ref yPos), new GUIContent("Game"), UbiCanvasSettings.GameMode);

		// Directories
		DrawHeader(ref yPos, "Directories");
		UbiCanvasSettings.ROGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Origins (PC)", UbiCanvasSettings.ROGameDataDir);
		UbiCanvasSettings.RLGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Legends (PC)", UbiCanvasSettings.RLGameDataDir);
		UbiCanvasSettings.RLVitaGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Legends (PSV)", UbiCanvasSettings.RLVitaGameDataDir);
		UbiCanvasSettings.RAGameDataDir = DirectoryField(GetNextRect(ref yPos), "Rayman Adventures (Android)", UbiCanvasSettings.RAGameDataDir);

		// If the current data directory has changed or no files were found then attempt to refresh the list of available levels
		if (PreviousGameDataFolder != UbiCanvasSettings.CurrentGameDataDir || AvailableFiles == null) {
			ShouldSearchAvailableFiles = true;
			PreviousGameDataFolder = UbiCanvasSettings.CurrentGameDataDir;
		}

		/*if (GUILayout.Button("Update available scenes")) {
			string path = EditorUtility.OpenFilePanel("Scene files", "", "isc.ckd");
			if (path.Length != 0) {
				//UbiCanvasSettings.SelectedLevelFile = AvailableFiles.ElementAtOrDefault(SelectedLevelFileIndex);
			}
		}*/
		// Scene file
		DrawHeader(ref yPos, "Scene file");

		string buttonString = "No level file selected";
		if (UbiCanvasSettings.SelectedLevelFile != null) {
			buttonString = Path.GetFileName(UbiCanvasSettings.SelectedLevelFile);
		}
		Rect rect = GetNextRect(ref yPos, vPaddingBottom: 4f);
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Selected file"));
		if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
			if (ShouldSearchAvailableFiles) {
				// Replace the directory separator character with a forward slash so that Unity will split them into sub-menus in the popup
				AvailableFiles = FindLevelFiles().Select(x => x.Replace(Path.DirectorySeparatorChar, '/')).ToArray();
				ShouldSearchAvailableFiles = false;
			}
			if (Dropdown == null || Dropdown.files != AvailableFiles) {
				Dropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState()) {
					name = "Scene files",
					files = AvailableFiles
				};
			}
			Dropdown.Show(rect);
		}
		if (Dropdown != null && Dropdown.selection != null) {
			UbiCanvasSettings.SelectedLevelFile = Dropdown.selection;
			Dropdown.selection = null;
			Dirty = true;
		}
		if (UbiCanvasSettings.SelectedLevelFile != null) {
			EditorGUI.TextArea(GetNextRect(ref yPos), UbiCanvasSettings.SelectedLevelFile);
		}

		// Misc
		DrawHeader(ref yPos, "Miscellaneous Settings");
		rect = GetNextRect(ref yPos);
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Serialization Log"));
		bool log = UbiCanvasSettings.Log;
		rect = PrefixToggle(rect, ref log);
		UbiCanvasSettings.Log = log;
		if (UbiCanvasSettings.Log) {
			UbiCanvasSettings.LogFile = FileField(rect, "Serialization Log File", UbiCanvasSettings.LogFile, true, "txt", includeLabel: false);
		}

		UbiCanvasSettings.LoadAnimations = EditorGUI.Toggle(GetNextRect(ref yPos), new GUIContent("Load Animations"), UbiCanvasSettings.LoadAnimations);

		if (EditorGUI.EndChangeCheck() || Dirty) {
			UbiCanvasSettings.Save();
			Dirty = false;
		}
	}

	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("Favorite");
		//titleContent = EditorGUIUtility.IconContent("Settings");
		titleContent.text = "Ubi-Canvas Setup";
		//UbiCanvasSettings.Load();
	}

	/*void OnFocus() {
		UbiCanvasSettings.Load();
	}

	void OnLostFocus() {
		UbiCanvasSettings.Save();
	}

	void OnDestroy() {
		UbiCanvasSettings.Save();
	}*/
	#endregion

	#region Private Methods
	void DrawHeader(ref float yPos, string title) {
		if (yPos > 0) {
			Rect rect = GetNextRect(ref yPos, padding: 0f, height: EditorStyles.toolbarButton.fixedHeight, vPadding: 4f);
			EditorGUI.LabelField(rect, new GUIContent(title), EditorStyles.toolbarButton);
		} else {
			Rect rect = GetNextRect(ref yPos, padding: 0f, height: EditorStyles.toolbarButton.fixedHeight, vPaddingBottom: 4f);
			EditorGUI.LabelField(rect, new GUIContent(title), EditorStyles.toolbarButton);
		}
	}
	Rect PrefixToggle(Rect rect, ref bool value) {
		value = EditorGUI.Toggle(new Rect(rect.x, rect.y, rect.height, rect.height), value);
		return new Rect(rect.x + rect.height, rect.y, rect.width - rect.height, rect.height);
	}
	Rect BrowseButton(Rect rect, string name, GUIContent content, Action action) {
		GUIStyle butStyle = EditorStyles.miniButtonRight;
		Rect buttonRect = new Rect(rect.x + rect.width - 24, rect.y, 24, rect.height);
		GUI.SetNextControlName("Button " + name);
		if (GUI.Button(buttonRect, content, butStyle)) {
			action();
		}
		return new Rect(rect.x, rect.y, rect.width - 24, rect.height);
	}
	string DirectoryField(Rect rect, string title, string value, bool includeLabel = true) {
		rect = BrowseButton(rect, title, EditorGUIUtility.IconContent("Folder Icon"), () => {
			string selectedFolder = EditorUtility.OpenFolderPanel(title, value, "");
			if (!string.IsNullOrEmpty(selectedFolder)) {
				GUI.FocusControl("Button " + title);
				value = selectedFolder;
				Dirty = true;
			}
		});
		if (!includeLabel) {
			value = EditorGUI.TextField(rect, value);
		} else {
			value = EditorGUI.TextField(rect, new GUIContent(title), value);
		}
		return value;
	}
	string FileField(Rect rect, string title, string value, bool save, string extension, bool includeLabel = true) {
		rect = BrowseButton(rect, title, EditorGUIUtility.IconContent("Folder Icon"), () => {
			string file;
			string directory = "";
			string defaultName = "";
			if (!string.IsNullOrEmpty(value)) {
				directory = Path.GetFileName(Path.GetFullPath(value));
				defaultName = Path.GetFileName(value);
			}
			if (save) {
				file = EditorUtility.SaveFilePanel(title, directory, defaultName, extension);
			} else {
				file = EditorUtility.OpenFilePanel(title, directory, extension);
			}
			if (!string.IsNullOrEmpty(file)) {
				//Debug.Log(file);
				GUI.FocusControl("Button " + title);
				value = file;
				Dirty = true;
			}
		});
		if (!includeLabel) {
			value = EditorGUI.TextField(rect, value);
		} else {
			value = EditorGUI.TextField(rect, new GUIContent(title), value);
		}
		return value;
	}
	/*Rect BrowseButtonRect(ref Rect rect) {
		Rect buttonRect = new Rect(rect.x + rect.width - 24, rect.y, 24, rect.height);
		rect = new Rect(rect.x, rect.y, rect.width - 24, rect.height);
		return buttonRect;
	}
	void BrowseButton(Rect rect, string name, GUIContent content, Action action) {
		GUIStyle butStyle = EditorStyles.miniButtonRight;
		GUI.SetNextControlName("Button " + name);
		if (GUI.Button(rect, content, butStyle)) {
			action();
		}
	}
	string DirectoryField(Rect rect, string title, string value) {
		GUIStyle butStyle = EditorStyles.miniButtonRight;
		Rect buttonRect = BrowseButtonRect(ref rect);
		GUI.SetNextControlName("TextField " + title);
		EditorGUI.TextField(rect, new GUIContent(title), value);
		BrowseButton(buttonRect, title, EditorGUIUtility.IconContent("Folder Icon"), () => {
			string selectedFolder = EditorUtility.OpenFolderPanel(title, value, "");
			if (!string.IsNullOrEmpty(selectedFolder)) {
				GUI.FocusControl("Button " + title);
				value = selectedFolder;
				UbiCanvasSettings.Save();
			}
		});
		if (title.Contains("PSV")) Debug.Log(value);
		return value;
	}*/

	/// <summary>
	/// Gets the relative path of all level files in the selected game data bin
	/// </summary>
	/// <returns>The relative paths</returns>
	private List<string> FindLevelFiles() {
		// Create the output
		var output = new List<string>();

		// If the directory does not exist, return the empty list
		if (!Directory.Exists(UbiCanvasSettings.CurrentGameDataDir))
			return output;

		// Initialize settings
		Settings.Init(UbiCanvasSettings.GameMode);

		string directory = (UbiCanvasSettings.CurrentGameDataDir + "/" + Settings.s.ITFDirectory).Replace('\\','/');
		if (!directory.EndsWith("/")) directory += "/";
		while (directory.Contains("//")) directory = directory.Replace("//", "/");



		// Add the found files containing the correct file extension
		output.AddRange(from file in Directory.EnumerateFiles(directory, "*.isc*", SearchOption.AllDirectories) select file.Substring(directory.Length));

		// Return the output
		return output;
	}

	#endregion

	#region Properties

	/// <summary>
	/// The selected level file index, based on <see cref="AvailableFiles"/>
	/// </summary>
	private int SelectedLevelFileIndex { get; set; }

	/// <summary>
	/// The available level files for the selected game
	/// </summary>
	private string[] AvailableFiles { get; set; }

	/// <summary>
	/// Next time the button is clicked, the directory should be searched for avaiable files
	/// </summary>
	private bool ShouldSearchAvailableFiles { get; set; }

	/// <summary>
	/// Copy of the previous game data folder for reference
	/// </summary>
	private string PreviousGameDataFolder { get; set; }

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown Dropdown { get; set; }


	/// <summary>
	/// Any changes made?
	/// </summary>
	private bool Dirty { get; set; }

	#endregion
}