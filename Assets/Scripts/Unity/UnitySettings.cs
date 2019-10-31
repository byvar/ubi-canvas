using System;
using System.Collections.Generic;
using UbiArt;
using UnityEditor;

/// <summary>
/// Settings for UbiCanvas
/// </summary>
[InitializeOnLoad]
public class UnitySettings {
	public static Dictionary<Settings.Mode, string> GameDirs = new Dictionary<Settings.Mode, string>();
	public static Dictionary<Settings.Mode, string> GameDirsWeb = new Dictionary<Settings.Mode, string>();

	public static Settings.Mode GameMode { get; set; } = Settings.Mode.RaymanLegendsPC;

    public static string SelectedLevelFile { get; set; }

	public static string LogFile { get; set; }

	public static bool Log { get; set; }

	public static bool LoadAnimations { get; set; } = true;

    /// <summary>
    /// Saves the settings
    /// </summary>
    public static void Save() {
		Settings.Mode[] modes = (Settings.Mode[])Enum.GetValues(typeof(Settings.Mode));
		foreach (Settings.Mode mode in modes) {
			string dir = GameDirs.ContainsKey(mode) ? GameDirs[mode] : "";
			EditorPrefs.SetString("Directory" + mode.ToString(), dir);
		}
		foreach (Settings.Mode mode in modes) {
			string dir = GameDirsWeb.ContainsKey(mode) ? GameDirsWeb[mode] : "";
			EditorPrefs.SetString("WebDirectory" + mode.ToString(), dir);
		}
		EditorPrefs.SetString("GameMode", GameMode.ToString());
		EditorPrefs.SetString("SelectedLevelFile", SelectedLevelFile);
		EditorPrefs.SetString("LogFile", LogFile);
		EditorPrefs.SetBool("Log", Log);
		EditorPrefs.SetBool(nameof(LoadAnimations), LoadAnimations);
	}

	/// <summary>
	/// Static constructor loads in editor data at editor startup.
	/// This way, the data loads even if the editor window isn't active.
	/// </summary>
	static UnitySettings() {
		Load();
	}

    /// <summary>
    /// Loads the settings
    /// </summary>
    public static void Load() {
		Settings.Mode[] modes = (Settings.Mode[])Enum.GetValues(typeof(Settings.Mode));
		foreach (Settings.Mode mode in modes) {
			string dir = GameDirs.ContainsKey(mode) ? GameDirs[mode] : "";
			GameDirs[mode] = EditorPrefs.GetString("Directory" + mode.ToString(), dir);
		}
		foreach (Settings.Mode mode in modes) {
			string dir = GameDirsWeb.ContainsKey(mode) ? GameDirsWeb[mode] : "";
			GameDirsWeb[mode] = EditorPrefs.GetString("WebDirectory" + mode.ToString(), dir);
		}
		GameMode = Enum.TryParse(EditorPrefs.GetString("GameMode", GameMode.ToString()), out Settings.Mode gameMode) ? gameMode : GameMode;
		SelectedLevelFile = EditorPrefs.GetString("SelectedLevelFile", SelectedLevelFile);
		LogFile = EditorPrefs.GetString("LogFile", LogFile);
		Log = EditorPrefs.GetBool("Log", Log);
		LoadAnimations = EditorPrefs.GetBool(nameof(LoadAnimations), LoadAnimations);
    }
}