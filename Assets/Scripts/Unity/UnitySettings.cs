using System;
using UbiArt;
using UnityEditor;

/// <summary>
/// Settings for UbiCanvas
/// </summary>
[InitializeOnLoad]
public class UnitySettings
{
    public static string ROGameDataDir { get; set; }

    public static string RLGameDataDir { get; set; }

    public static string RLVitaGameDataDir { get; set; }

    public static string RAGameDataDir { get; set; }

    public static Settings.Mode GameMode { get; set; } = Settings.Mode.RaymanLegendsPC;

    public static string CurrentGameDataDir
    {
        get
        {
            switch (GameMode)
            {
                case Settings.Mode.RaymanOriginsPC:
                    return ROGameDataDir;

                case Settings.Mode.RaymanLegendsPC:
                    return RLGameDataDir;

                case Settings.Mode.RaymanLegendsVitaCatchThemAll:
                    return RLVitaGameDataDir;

                case Settings.Mode.RaymanAdventuresAndroid:
                    return RAGameDataDir;

                default:
                    throw new ArgumentOutOfRangeException(nameof(GameMode));
            }
        }
    }

    public static string SelectedLevelFile { get; set; }

	public static string LogFile { get; set; }

	public static bool Log { get; set; }

	public static bool LoadAnimations { get; set; } = true;

    /// <summary>
    /// Saves the settings
    /// </summary>
    public static void Save()
    {
        EditorPrefs.SetString(nameof(ROGameDataDir), ROGameDataDir);
        EditorPrefs.SetString(nameof(RLGameDataDir), RLGameDataDir);
        EditorPrefs.SetString(nameof(RLVitaGameDataDir), RLVitaGameDataDir);
        EditorPrefs.SetString(nameof(RAGameDataDir), RAGameDataDir);
        EditorPrefs.SetString("UbiGameMode", GameMode.ToString());
        EditorPrefs.SetString("SelectedUbiLevelFile", SelectedLevelFile);
		EditorPrefs.SetString("UbiLogFile", LogFile);
		EditorPrefs.SetBool("UbiLog", Log);
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
    public static void Load()
    {
        ROGameDataDir = EditorPrefs.GetString(nameof(ROGameDataDir), ROGameDataDir);
        RLGameDataDir = EditorPrefs.GetString(nameof(RLGameDataDir), RLGameDataDir);
        RLVitaGameDataDir = EditorPrefs.GetString(nameof(RLVitaGameDataDir), RLVitaGameDataDir);
        RAGameDataDir = EditorPrefs.GetString(nameof(RAGameDataDir), RAGameDataDir);
        GameMode = Enum.TryParse(EditorPrefs.GetString("UbiGameMode", GameMode.ToString()), out Settings.Mode gameMode) ? gameMode : GameMode;
        SelectedLevelFile = EditorPrefs.GetString("SelectedUbiLevelFile", SelectedLevelFile);
		LogFile = EditorPrefs.GetString("UbiLogFile", LogFile);
		Log = EditorPrefs.GetBool("UbiLog", Log);
		LoadAnimations = EditorPrefs.GetBool(nameof(LoadAnimations), LoadAnimations);
    }
}