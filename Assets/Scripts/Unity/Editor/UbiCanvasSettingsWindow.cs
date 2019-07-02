using System.Collections.Generic;
using System.IO;
using System.Linq;
using UbiArt;
using UnityEditor;
using Path = System.IO.Path;

public class UbiCanvasSettingsWindow : EditorWindow
{
    #region Unity Methods

    [MenuItem("Ubi-Canvas/Ubi-Canvas Setup")]
    public static void ShowWindow()
    {
        GetWindow<UbiCanvasSettingsWindow>(false, "Ubi-Canvas Setup", true);
    }

    public void OnGUI()
    {
        // Increase label width due to it being cut off otherwise
        EditorGUIUtility.labelWidth = 280;

        // Update game mode first
        UbiCanvasSettings.GameMode = (Settings.Mode)EditorGUILayout.EnumPopup("Game", UbiCanvasSettings.GameMode);

        // If the current data directory has changed or no files were found then attempt to refresh the list of available levels
        if (PreviousGameDataFolder != UbiCanvasSettings.CurrentGameDataDir || AvailableFiles == null)
        {
            AvailableFiles = FindLevelFiles().
                // Replace the directory separator character with a forward slash so that Unity will split them into sub-menus in the popup
                Select(x => x.Replace(Path.DirectorySeparatorChar, '/')).ToArray();

            PreviousGameDataFolder = UbiCanvasSettings.CurrentGameDataDir;
        }

        // Update the data and create controls
        UbiCanvasSettings.ROGameDataDir = EditorGUILayout.TextField("Rayman Origins data", UbiCanvasSettings.ROGameDataDir);
        UbiCanvasSettings.RLGameDataDir = EditorGUILayout.TextField("Rayman Legends data", UbiCanvasSettings.RLGameDataDir);
        UbiCanvasSettings.RLVitaCatchThemAllGameDataDir = EditorGUILayout.TextField("Rayman Legends PS Vita Catch Them All data", UbiCanvasSettings.RLVitaCatchThemAllGameDataDir);
        UbiCanvasSettings.RAGameDataDir = EditorGUILayout.TextField("Rayman Adventures data", UbiCanvasSettings.RAGameDataDir);
        SelectedLevelFileIndex = EditorGUILayout.Popup("Scene", SelectedLevelFileIndex, AvailableFiles);
        UbiCanvasSettings.SelectedLevelFile = AvailableFiles.ElementAtOrDefault(SelectedLevelFileIndex);

        // Buttons to manually save
        //if (GUILayout.Button("Load"))
        //    UbiCanvasSettings.Load();

        //if (GUILayout.Button("Save"))
        //    UbiCanvasSettings.Save();
    }

    void OnFocus()
    {
        UbiCanvasSettings.Load();
    }

    void OnLostFocus()
    {
        UbiCanvasSettings.Save();
    }

    void OnDestroy()
    {
        UbiCanvasSettings.Save();
    }
    #endregion

    #region Private Methods

    /// <summary>
    /// Gets the relative path of all level files in the selected game data bin
    /// </summary>
    /// <returns>The relative paths</returns>
    private List<string> FindLevelFiles()
    {
        // Create the output
        var output = new List<string>();

        // If the directory does not exist, return the empty list
        if (!Directory.Exists(UbiCanvasSettings.CurrentGameDataDir))
            return output;

        // Add the found files containing the correct file extension
        output.AddRange(from file in Directory.EnumerateFiles(UbiCanvasSettings.CurrentGameDataDir, "*.isc*", SearchOption.AllDirectories) select file.Remove(0, UbiCanvasSettings.CurrentGameDataDir.Length + 1));

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
    /// Copy of the previous game data folder for reference
    /// </summary>
    private string PreviousGameDataFolder { get; set; }

    #endregion
}