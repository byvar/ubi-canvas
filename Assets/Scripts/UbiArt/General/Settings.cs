using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UbiArt {
	public class Settings {
		public enum Mode {
			RaymanOriginsPC, RaymanLegendsPC, RaymanLegendsVitaCatchThemAll, RaymanAdventuresIOS, RaymanAdventuresAndroid
		};
		public Mode mode = Mode.RaymanLegendsPC;

		public enum EngineVersion {
			None = -1,
			RO = 0,
			RL = 1
		};
		public enum Game { None, RO, RL, RA, RJR, RFR, COL, VH };
		public enum Platform { None, PC, iOS, Android, WiiU, Vita };
		public enum Endian { Little, Big };
		public enum SerializerType { Binary, TagBinary };

		public EngineVersion engineVersion;
		public Game game;
		public Platform platform;
		public Endian endian;
		public VersionFlags versionFlags;
		public SerializerType serializerType = SerializerType.Binary;
		public bool usesSerializeFlags = true;
		public bool isCatchThemAll = false;

		public bool IsLittleEndian {
			get { return endian == Endian.Little; }
		}
		public string PlatformString {
			get {
				switch (platform) {
					case Platform.PC: return "pc";
					case Platform.Android: return "android";
					default: return null;
				}
			}
		}

		public static void Init(Mode mode) {
			switch (mode) {
				case Mode.RaymanOriginsPC: s = ROPC; break;
				case Mode.RaymanLegendsPC: s = RLPC; break;
				case Mode.RaymanLegendsVitaCatchThemAll: s = RLVita; break;
				case Mode.RaymanAdventuresIOS: s = RAIOS; break;
				case Mode.RaymanAdventuresAndroid: s = RAAndroid; break;
			}
			if (s != null) s.mode = mode;
		}


		public static Settings s = null;
		public static Settings ROPC = new Settings() {
			engineVersion = EngineVersion.RO,
			game = Game.RO,
			platform = Platform.PC,
			endian = Endian.Big,
			versionFlags = VersionFlags.Origins,
			usesSerializeFlags = false
		};
		public static Settings RLPC = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.PC,
			endian = Endian.Big,
			versionFlags = VersionFlags.Legends
		};
		public static Settings RAIOS = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.iOS,
			endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RAAndroid = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.Android,
			endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RLVita = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.Vita,
			endian = Endian.Big,
			versionFlags = VersionFlags.Legends,
			isCatchThemAll = true
		};
	}
}