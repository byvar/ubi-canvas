using System;
using System.Collections.Generic;
using System.IO;
using UbiArt;
using UbiCanvas.Helpers;
using UnityEngine;

/// <summary>
/// Settings for UbiCanvas
/// </summary>
#if UNITY_EDITOR
[UnityEditor.InitializeOnLoad]
#endif
public class UnitySettings {
	private const string editorPrefsPrefix = "UbiCanvas.";
	private const string settingsFile = "Settings.txt";


	public static Dictionary<Settings.Mode, string> GameDirs = new Dictionary<Settings.Mode, string>();
	public static Dictionary<Settings.Mode, string> GameDirsWeb = new Dictionary<Settings.Mode, string>();

	public static Settings.Mode GameMode { get; set; } = Settings.Mode.RaymanLegendsPC;

    public static string SelectedLevelFile { get; set; }

	// Log
	public static string LogFile { get; set; }
	public static bool Log { get; set; }

	public static bool BackupFiles { get; set; }

	// Loading
	public static bool LoadAnimations { get; set; } = true;
    public static bool LoadAllPaths { get; set; }
	
	// Export window
	public static bool Export_UseRaw { get; set; } = false;
	public static string Export_OutputPathFile { get; set; }
	public static string Export_OutputPathFolder { get; set; }

	// Build mod IPK tool
	public static Settings.Mode Tools_BuildModIPK_GameMode { get; set; } = Settings.Mode.RaymanLegendsPC;
	public static string Tools_BuildModIPK_InputPath { get; set; }
	public static string Tools_BuildModIPK_OriginalBundlesPath { get; set; }
	public static string Tools_BuildModIPK_BundleBaseName { get; set; }
	public static string Tools_BuildModIPK_OutputPath { get; set; }
	public static string Tools_BuildModIPK_BundleOrder { get; set; }
	public static bool Tools_BuildModIPK_CreateSecureFatAfterIPK { get; set; }

	// Adventures to Legends converter
	public static string Tools_AdventuresToLegends_ProjectPath { get; set; }
	public static string Tools_AdventuresToLegends_GamePath { get; set; }

	// Mode conversion tool
	public static Settings.Mode Tools_ModeConversion_InputMode { get; set; } = Settings.Mode.RaymanOriginsPC;
	public static string Tools_ModeConversion_InputPath { get; set; }
	public static Settings.Mode Tools_ModeConversion_OutputMode { get; set; } = Settings.Mode.RaymanLegendsPC;
	public static string Tools_ModeConversion_OutputPath { get; set; }

	/// <summary>
	/// Static constructor loads in editor data at editor startup.
	/// This way, the data loads even if the editor window isn't active.
	/// </summary>
	static UnitySettings() {
		Load();
	}


    #region Public Methods

    private static void SerializeSettings(ISerializer s, bool cmdLine = false) {
        if (!cmdLine) {
            Settings.Mode[] modes = (Settings.Mode[])Enum.GetValues(typeof(Settings.Mode));
            foreach (Settings.Mode mode in modes) {
                string dir = GameDirs.ContainsKey(mode) ? GameDirs[mode] : "";
                GameDirs[mode] = s.SerializeString("Directory" + mode.ToString(), dir);
            }
            if (Application.isEditor) {
                foreach (Settings.Mode mode in modes) {
                    string dir = GameDirsWeb.ContainsKey(mode) ? GameDirsWeb[mode] : "";
                    GameDirsWeb[mode] = s.SerializeString("WebDirectory" + mode.ToString(), dir);
                }
            }
        }
        string modeString = s.SerializeString(nameof(GameMode), GameMode.ToString(), "mode", "m");
        GameMode = Enum.TryParse<Settings.Mode>(modeString, out Settings.Mode gameMode) ? gameMode : GameMode;
        if (cmdLine) {
            if (Settings.cmdModeNameDict.ContainsKey(modeString)) {
                GameMode = Settings.cmdModeNameDict[modeString];
            }
            if (FileSystem.mode == FileSystem.Mode.Web) {
                string dir = GameDirsWeb.ContainsKey(GameMode) ? GameDirsWeb[GameMode] : "";
                GameDirsWeb[GameMode] = s.SerializeString("WebDirectory", dir, "dir", "directory", "folder", "f", "d");
            } else {
                string dir = GameDirs.ContainsKey(GameMode) ? GameDirs[GameMode] : "";
                GameDirs[GameMode] = s.SerializeString("Directory", dir, "dir", "directory", "folder", "f", "d");
            }
        }

        SelectedLevelFile = s.SerializeString(nameof(SelectedLevelFile), SelectedLevelFile, "level", "lvl", "map");
        LoadAnimations = s.SerializeBool(nameof(LoadAnimations), LoadAnimations);
        LoadAllPaths = s.SerializeBool(nameof(LoadAllPaths), LoadAllPaths);
        
        BackupFiles = s.SerializeBool(nameof(BackupFiles), BackupFiles);
        Log = s.SerializeBool(nameof(Log), Log);
        LogFile = s.SerializeString(nameof(LogFile), LogFile);

		Export_UseRaw = s.SerializeBool(nameof(Export_UseRaw), Export_UseRaw);
		Export_OutputPathFile = s.SerializeString(nameof(Export_OutputPathFile), Export_OutputPathFile);
		Export_OutputPathFolder = s.SerializeString(nameof(Export_OutputPathFolder), Export_OutputPathFolder);


		modeString = s.SerializeString(nameof(Tools_BuildModIPK_GameMode), Tools_BuildModIPK_GameMode.ToString());
		Tools_BuildModIPK_GameMode = Enum.TryParse<Settings.Mode>(modeString, out Settings.Mode gameModeIPK) ? gameModeIPK : Tools_BuildModIPK_GameMode;
		Tools_BuildModIPK_BundleBaseName = s.SerializeString(nameof(Tools_BuildModIPK_BundleBaseName), Tools_BuildModIPK_BundleBaseName);
		Tools_BuildModIPK_OriginalBundlesPath = s.SerializeString(nameof(Tools_BuildModIPK_OriginalBundlesPath), Tools_BuildModIPK_OriginalBundlesPath);
		Tools_BuildModIPK_InputPath = s.SerializeString(nameof(Tools_BuildModIPK_InputPath), Tools_BuildModIPK_InputPath);
		Tools_BuildModIPK_OutputPath = s.SerializeString(nameof(Tools_BuildModIPK_OutputPath), Tools_BuildModIPK_OutputPath);
		Tools_BuildModIPK_BundleOrder = s.SerializeString(nameof(Tools_BuildModIPK_BundleOrder), Tools_BuildModIPK_BundleOrder);
		Tools_BuildModIPK_CreateSecureFatAfterIPK = s.SerializeBool(nameof(Tools_BuildModIPK_CreateSecureFatAfterIPK), Tools_BuildModIPK_CreateSecureFatAfterIPK);

		Tools_AdventuresToLegends_ProjectPath = s.SerializeString(nameof(Tools_AdventuresToLegends_ProjectPath), Tools_AdventuresToLegends_ProjectPath);
		Tools_AdventuresToLegends_GamePath = s.SerializeString(nameof(Tools_AdventuresToLegends_GamePath), Tools_AdventuresToLegends_GamePath);

		modeString = s.SerializeString(nameof(Tools_ModeConversion_InputMode), Tools_ModeConversion_InputMode.ToString());
		Tools_ModeConversion_InputMode = Enum.TryParse<Settings.Mode>(modeString, out Settings.Mode gameModeConvInput) ? gameModeConvInput : Tools_ModeConversion_InputMode;
		Tools_ModeConversion_InputPath = s.SerializeString(nameof(Tools_ModeConversion_InputPath), Tools_ModeConversion_InputPath);
		modeString = s.SerializeString(nameof(Tools_ModeConversion_OutputMode), Tools_ModeConversion_OutputMode.ToString());
		Tools_ModeConversion_OutputMode = Enum.TryParse<Settings.Mode>(modeString, out Settings.Mode gameModeConvOutput) ? gameModeConvOutput : Tools_ModeConversion_OutputMode;
		Tools_ModeConversion_OutputPath = s.SerializeString(nameof(Tools_ModeConversion_OutputPath), Tools_ModeConversion_OutputPath);
	}

    /// <summary>
    /// Saves the settings
    /// </summary>
    public static void Save() {
        if (Application.isEditor) {
#if UNITY_EDITOR
            ISerializer s = new EditorWriteSerializer();
            SerializeSettings(s);
#endif
        } else if (Application.platform != RuntimePlatform.WebGLPlayer) {
            using (SettingsFileWriteSerializer s = new SettingsFileWriteSerializer(settingsFile)) {
                SerializeSettings(s);
            }
        }
    }

    /// <summary>
    /// Loads the settings
    /// </summary>
    public static void Load() {
		System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
		if (Application.isEditor) {
#if UNITY_EDITOR
            ISerializer s = new EditorReadSerializer();
            SerializeSettings(s);
#endif
        } else if (Application.platform != RuntimePlatform.WebGLPlayer) {
            if (!File.Exists(settingsFile)) {
                Save();
            }
            ISerializer s = new SettingsFileReadSerializer(settingsFile);
            SerializeSettings(s);
        }
        ConfigureFileSystem();
        if (!Application.isEditor) {
            ParseCommandLineArguments();
        }
    }

    public static void ConfigureFileSystem() {

        if (Application.platform == RuntimePlatform.WebGLPlayer) {
            FileSystem.mode = FileSystem.Mode.Web;
        }
#if UNITY_EDITOR
        if (Application.isEditor && UnityEditor.EditorUserBuildSettings.activeBuildTarget == UnityEditor.BuildTarget.WebGL) {
            FileSystem.mode = FileSystem.Mode.Web;
        }
#endif
    }

    static void ParseCommandLineArguments() {
        if (Application.platform == RuntimePlatform.WebGLPlayer) {
            // Read URL arguments
            ISerializer s = new WebArgumentsReadSerializer();
            SerializeSettings(s, cmdLine: true);
        } else {
            // Read command line arguments
            ISerializer s = new CmdLineReadSerializer();
            SerializeSettings(s, cmdLine: true);
        }
    }

    #endregion

    #region Subclasses (Settings serialization)

    private interface ISerializer {
        string SerializeString(string key, string value, params string[] cmdlineKeys);
        bool SerializeBool(string key, bool value, params string[] cmdlineKeys);
        int SerializeInt(string key, int value, params string[] cmdlineKeys);
    }

#if UNITY_EDITOR
    private class EditorReadSerializer : ISerializer {
        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            return UnityEditor.EditorPrefs.GetBool(editorPrefsPrefix + key, value);
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            return UnityEditor.EditorPrefs.GetString(editorPrefsPrefix + key, value);
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            return UnityEditor.EditorPrefs.GetInt(editorPrefsPrefix + key, value);
        }
    }

    private class EditorWriteSerializer : ISerializer {
        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            UnityEditor.EditorPrefs.SetBool(editorPrefsPrefix + key, value);
            return value;
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            UnityEditor.EditorPrefs.SetString(editorPrefsPrefix + key, value);
            return value;
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            UnityEditor.EditorPrefs.SetInt(editorPrefsPrefix + key, value);
            return value;
        }
    }
#endif

    private class CmdLineReadSerializer : ISerializer {
        string[] args;
        public CmdLineReadSerializer() {
            args = Environment.GetCommandLineArgs();
        }

        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            if (args == null || args.Length == 0 || cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            for (int c = 0; c < cmdlineKeys.Length; c++) {
                string cmdKey = cmdlineKeys[c];
                if (cmdKey.Length == 1) {
                    cmdKey = "-" + cmdKey;
                } else {
                    cmdKey = "--" + cmdKey;
                }
                int ind = Array.IndexOf(args, cmdKey);
                if (ind > -1 && ind + 1 < args.Length) {
                    if (bool.TryParse(args[ind + 1], out bool b)) {
                        return b;
                    }
                }
            }
            return value;
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            if (args == null || args.Length == 0 || cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            for (int c = 0; c < cmdlineKeys.Length; c++) {
                string cmdKey = cmdlineKeys[c];
                if (cmdKey.Length == 1) {
                    cmdKey = "-" + cmdKey;
                } else {
                    cmdKey = "--" + cmdKey;
                }
                int ind = Array.IndexOf(args, cmdKey);
                if (ind > -1 && ind + 1 < args.Length) {
                    return args[ind + 1];
                }
            }
            return value;
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            if (args == null || args.Length == 0 || cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            for (int c = 0; c < cmdlineKeys.Length; c++) {
                string cmdKey = cmdlineKeys[c];
                if (cmdKey.Length == 1) {
                    cmdKey = "-" + cmdKey;
                } else {
                    cmdKey = "--" + cmdKey;
                }
                int ind = Array.IndexOf(args, cmdKey);
                if (ind > -1 && ind + 1 < args.Length) {
                    if (int.TryParse(args[ind + 1], out int val)) {
                        return val;
                    }
                }
            }
            return value;
        }
    }

    private class WebArgumentsReadSerializer : ISerializer {
        Dictionary<string, string> settings = new Dictionary<string, string>();
        public WebArgumentsReadSerializer() {
            string url = Application.absoluteURL;
            if (url.IndexOf('?') > 0) {
                string urlArgsStr = url.Split('?')[1].Split('#')[0];
                if (urlArgsStr.Length > 0) {
                    string[] urlArgs = urlArgsStr.Split('&');
                    foreach (string arg in urlArgs) {
                        string[] argKeyVal = arg.Split('=');
                        if (argKeyVal.Length > 1) {
                            settings.Add(argKeyVal[0], argKeyVal[1]);
                        }
                    }
                }
            }
        }

        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                if (bool.TryParse(settings[key], out bool b)) {
                    return b;
                }
            }
            if (cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            foreach (string cmdKey in cmdlineKeys) {
                if (settings.ContainsKey(cmdKey)) {
                    if (bool.TryParse(settings[cmdKey], out bool b)) {
                        return b;
                    }
                }
            }
            return value;
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                return settings[key];
            }
            if (cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            foreach (string cmdKey in cmdlineKeys) {
                if (settings.ContainsKey(cmdKey)) {
                    return settings[cmdKey];
                }
            }
            return value;
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                if (int.TryParse(settings[key], out int i)) {
                    return i;
                }
            }
            if (cmdlineKeys == null || cmdlineKeys.Length == 0) return value;
            foreach (string cmdKey in cmdlineKeys) {
                if (settings.ContainsKey(cmdKey)) {
                    if (int.TryParse(settings[cmdKey], out int i)) {
                        return i;
                    }
                }
            }
            return value;
        }
    }

    private class SettingsFileWriteSerializer : ISerializer, IDisposable {
        StreamWriter writer;
        public SettingsFileWriteSerializer(string path) {
            writer = new StreamWriter(path);
        }

        public void Dispose() {
            writer?.Flush();
            ((IDisposable)writer)?.Dispose();
        }

        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            writer.WriteLine(key + "=" + value.ToString());
            return value;
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            writer.WriteLine(key + "=" + value.ToString());
            return value;
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            writer.WriteLine(key + "=" + value.ToString());
            return value;
        }
    }

    private class SettingsFileReadSerializer : ISerializer {
        Dictionary<string, string> settings = new Dictionary<string, string>();
        public SettingsFileReadSerializer(string path) {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++) {
                // Not using split, just in case any of the values contain a =
                int index = lines[i].IndexOf('=');
                if (index >= 0 && index < lines[i].Length) {
                    settings.Add(lines[i].Substring(0, index), lines[i].Substring(index + 1));
                }
            }
        }

        public bool SerializeBool(string key, bool value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                if (bool.TryParse(settings[key], out bool b)) {
                    return b;
                }
            }
            return value;
        }

        public string SerializeString(string key, string value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                return settings[key];
            }
            return value;
        }

        public int SerializeInt(string key, int value, params string[] cmdlineKeys) {
            if (settings.ContainsKey(key)) {
                if (int.TryParse(settings[key], out int i)) {
                    return i;
                }
            }
            return value;
        }
    }
    #endregion
}