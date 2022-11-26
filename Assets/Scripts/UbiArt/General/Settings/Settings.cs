using System.Collections.Generic;
using System.Text;

namespace UbiArt {
	public class Settings {
		public enum Mode {
			[System.ComponentModel.Description("Rayman Origins (PC)")] RaymanOriginsPC,
			[System.ComponentModel.Description("Rayman Legends (PC)")] RaymanLegendsPC,
			[System.ComponentModel.Description("Rayman Legends (PSV)")] RaymanLegendsVitaCatchThemAll,
			//RaymanAdventuresIOS,
			[System.ComponentModel.Description("Rayman Adventures (Android)")] RaymanAdventuresAndroid,
			[System.ComponentModel.Description("Rayman Mini (MacOS)")] RaymanMiniMacOS
		};
		public Mode mode = Mode.RaymanLegendsPC;


		public static readonly Dictionary<string, Mode> cmdModeNameDict = new Dictionary<string, Mode>() {
			{ "ro_pc", Mode.RaymanOriginsPC },
			{ "rl_pc", Mode.RaymanLegendsPC },
			{ "rl_vita", Mode.RaymanLegendsVitaCatchThemAll },
			{ "ra_android", Mode.RaymanAdventuresAndroid },
			{ "rm_mac", Mode.RaymanMiniMacOS },
		};


		// TODO: Move these enums out of Settings folder into Enums
		public enum EngineVersion {
			None = -1,
			RO = 0,
			RL = 1
		};
		public enum Game { None, RO, RL, RA, RJR, RFR, COL, VH, RM };
		public enum Platform { None, PC, iOS, Android, WiiU, Vita, MacOS };
		public enum SerializerType { Binary, TagBinary };

		public EngineVersion engineVersion;
		public Game game;
		public Platform platform;
		public Endian Endian { get; set; }
		public VersionFlags versionFlags;
		public SerializerType serializerType = SerializerType.Binary;
		public bool usesSerializeFlags = true;
		public bool isCatchThemAll = false;
		public bool cooked = true;
		public bool loadFromIPK = false;
		public static Encoding StringEncoding { get; set; } = Encoding.UTF8;
		public string[] bundles;

		public bool IsLittleEndian {
			get { return Endian == Endian.Little; }
		}
		public string PlatformString {
			get {
				switch (platform) {
					case Platform.PC: return "PC";
					case Platform.Android: return "android";
					case Platform.MacOS: return "macos";
					default: return null;
				}
			}
		}
		public string ITFDirectory {
			get {
				if (cooked) {
					if (engineVersion > EngineVersion.RO) {
						return "cache/itf_cooked/" + PlatformString.ToLower() + "/";
					} else {
						return "itf_cooked/" + PlatformString.ToLower() + "/";
					}
				} else {
					return "";
				}
			}
		}

		public static Settings Init(Mode mode) {
			Settings s = null;
			if (settingsDict.ContainsKey(mode)) {
				s = settingsDict[mode];
			}
			if (s != null) s.mode = mode;
			return s;
		}

		public static Settings ROPC = new Settings() {
			engineVersion = EngineVersion.RO,
			game = Game.RO,
			platform = Platform.PC,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Origins,
			usesSerializeFlags = false,
			bundles = new string[] { "bundle" }
		};
		public static Settings RLPC = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.PC,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Legends,
			bundles = new string[] {
				"persistentLoading", "Bundle"
			}
		};
		public static Settings RAIOS = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.iOS,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RAAndroid = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.Android,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary,
			bundles = new string[] {
				"bundle",
				"bundlemain",
				"bundleonboardingadv1",
				"bundleonboardingadv2",
				"bundleonboardingadv3",
				"bundlepersonal",
				"bundlemedieval",
				"bundleshaolin",
				"bundletoadstory",
				"bundleunderwater",
				"bundledesert",
				"bundlegreece",
				"bundlelod",
				"fulllogic",
				"fulllogicmain",
				"fulllogiconboardingadv1",
				"fulllogiconboardingadv2",
				"fulllogiconboardingadv3",
				"fulllogicpersonal",
				"fulllogicmedieval",
				"fulllogicshaolin",
				"fulllogictoadstory",
				"fulllogicunderwater",
				"fulllogicdesert",
				"fulllogicgreece",
				"fulllogiclod"

			}
		};
		public static Settings RMMac = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RM,
			platform = Platform.MacOS,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary,
			bundles = new string[] { "bundle" }
		};
		public static Settings RLVita = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.Vita,
			Endian = Endian.Big,
			versionFlags = VersionFlags.Legends,
			isCatchThemAll = true
		};


		public static readonly Dictionary<Mode, Settings> settingsDict = new Dictionary<Mode, Settings>() {
			{ Mode.RaymanOriginsPC, ROPC },
			{ Mode.RaymanLegendsPC, RLPC },
			{ Mode.RaymanLegendsVitaCatchThemAll, RLVita },
			{ Mode.RaymanAdventuresAndroid, RAAndroid },
			{ Mode.RaymanMiniMacOS, RMMac },
		};
	}
}