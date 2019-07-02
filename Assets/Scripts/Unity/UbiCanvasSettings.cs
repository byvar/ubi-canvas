using System;
using UbiArt;
using UnityEditor;

/// <summary>
/// Settings for UbiCanvas
/// </summary>
public static class UbiCanvasSettings
{
    public static string ROGameDataDir { get; set; }

    public static string RLGameDataDir { get; set; }

    public static string RLVitaCatchThemAllGameDataDir { get; set; }

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
                    return RLVitaCatchThemAllGameDataDir;

                case Settings.Mode.RaymanAdventuresAndroid:
                    return RAGameDataDir;

                default:
                    throw new ArgumentOutOfRangeException(nameof(GameMode));
            }
        }
    }

    public static string SelectedLevelFile { get; set; }

    /// <summary>
    /// Saves the settings
    /// </summary>
    public static void Save()
    {
        EditorPrefs.SetString(nameof(ROGameDataDir), ROGameDataDir);
        EditorPrefs.SetString(nameof(RLGameDataDir), RLGameDataDir);
        EditorPrefs.SetString(nameof(RLVitaCatchThemAllGameDataDir), RLVitaCatchThemAllGameDataDir);
        EditorPrefs.SetString(nameof(RAGameDataDir), RAGameDataDir);
        EditorPrefs.SetString("UbiGameMode", GameMode.ToString());
        EditorPrefs.SetString("SelectedUbiLevelFile", SelectedLevelFile);
    }

    /// <summary>
    /// Loads the settings
    /// </summary>
    public static void Load()
    {
        ROGameDataDir = EditorPrefs.GetString(nameof(ROGameDataDir), ROGameDataDir);
        RLGameDataDir = EditorPrefs.GetString(nameof(RLGameDataDir), RLGameDataDir);
        RLVitaCatchThemAllGameDataDir = EditorPrefs.GetString(nameof(RLVitaCatchThemAllGameDataDir), RLVitaCatchThemAllGameDataDir);
        RAGameDataDir = EditorPrefs.GetString(nameof(RAGameDataDir), RAGameDataDir);
        GameMode = Enum.TryParse(EditorPrefs.GetString("UbiGameMode", GameMode.ToString()), out Settings.Mode gameMode) ? gameMode : GameMode;
        SelectedLevelFile = EditorPrefs.GetString("SelectedUbiLevelFile", SelectedLevelFile);
    }
}