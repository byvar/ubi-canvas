#nullable enable
using System;

namespace UbiArt
{
	public class Settings
	{
		#region Public Properties

		// TODO: The default values are a bit all over the place. Perhaps pick one to use as default? Or require parameters from constructor?
		public Mode Mode { get; set; } = Mode.RaymanLegendsPC;
		public EngineVersion EngineVersion { get; set; } = EngineVersion.RO;
		public Game Game { get; set; } = Game.None;
		public GamePlatform Platform { get; set; } = GamePlatform.None;
		public SerializerType SerializerType { get; set; } = SerializerType.Binary;
		public Endian Endian { get; set; } = Endian.Little;
		public VersionFlags VersionFlags { get; set; } = VersionFlags.None;
		public bool SsesSerializeFlags { get; set; } = true;
		public bool IsCatchThemAll { get; set; }
		public bool Cooked { get; set; } = true;
		public bool LoadFromIpk { get; set; }
		public string[]? Bundles { get; set; }
		public uint IpkVersion { get; set; }
		public uint EngineSignature { get; set; }

		public bool IsLittleEndian => Endian == Endian.Little;

		public string PlatformString => Platform switch
		{
			GamePlatform.PC => "PC",
			GamePlatform.Android => "android",
			GamePlatform.iOS => "ios",
			GamePlatform.MacOS => "macos",
			GamePlatform.Vita => "VITA",
			GamePlatform.PC32 => "PC32",
			_ => throw new InvalidOperationException($"Can not get a platform string for the platform {Platform}")
		};

		public string ITFDirectory
		{
			get
			{
				if (!Cooked)
					return String.Empty;
				else if (EngineVersion > EngineVersion.RO)
					return "cache/itf_cooked/" + PlatformString.ToLower() + "/";
				else
					return "itf_cooked/" + PlatformString.ToLower() + "/";
			}
		}

		public string ITFCacheDirectory
		{
			get
			{
				if (!Cooked)
					return String.Empty;
				else if (EngineVersion > EngineVersion.RO)
					return "cache/itf_cache/" + PlatformString.ToLower() + "/";
				else
					return "itf_cache/" + PlatformString.ToLower() + "/";
			}
		}

		#endregion

		#region Defined Settings

		public static Settings RO_PC = new()
		{
			EngineVersion = EngineVersion.RO,
			Game = Game.RO,
			Platform = GamePlatform.PC,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Origins,
			SsesSerializeFlags = false,
			IpkVersion = 3,
			EngineSignature = 0x345429C7,
			Bundles = new[] { "bundle" }
		};

		public static Settings RL_PC = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.RL,
			Platform = GamePlatform.PC,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Legends,
			IpkVersion = 5,
			EngineSignature = 0x4BFC7C03,
			Bundles = new[] { "persistentLoading", "Bundle" }
		};

		public static Settings RA_iOS = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.RA,
			Platform = GamePlatform.iOS,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Adventures,
			SerializerType = SerializerType.TagBinary,
			IpkVersion = 8,
			EngineSignature = 0x2FB967E7,
			Bundles = new[]
			{
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

		public static Settings RA_Android = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.RA,
			Platform = GamePlatform.Android,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Adventures,
			SerializerType = SerializerType.TagBinary,
			IpkVersion = 8,
			EngineSignature = 0x2FB967E7,
			Bundles = new[] 
			{
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

		public static Settings RM_MacOS = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.RM,
			Platform = GamePlatform.MacOS,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Adventures,
			SerializerType = SerializerType.TagBinary,
			IpkVersion = 8,
			EngineSignature = 0x2FB967E7,
			Bundles = new[] { "bundle" }
		};

		public static Settings RL_Vita = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.RL,
			Platform = GamePlatform.Vita,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Legends,
			IsCatchThemAll = true,
			Bundles = new[] { "Bundle" }
		};

		public static Settings COL_PC32 = new()
		{
			EngineVersion = EngineVersion.RL,
			Game = Game.COL,
			Platform = GamePlatform.PC32,
			Endian = Endian.Big,
			VersionFlags = VersionFlags.Legends,
			IpkVersion = 5,
			EngineSignature = 0x4BFC7C03,
		};

		#endregion

		#region Public Methods

		public static Settings? FromMode(Mode mode)
		{
			Settings? settings = mode switch
			{
				Mode.RaymanOriginsPC => RO_PC,
				Mode.RaymanLegendsPC => RL_PC,
				Mode.RaymanLegendsVitaCatchThemAll => RL_Vita,
				Mode.RaymanAdventuresAndroid => RA_Android,
				Mode.RaymanAdventuresiOS => RA_iOS,
				Mode.RaymanMiniMacOS => RM_MacOS,
				Mode.ChildOfLightPC => COL_PC32,
				_ => null,
			};

			if (settings != null)
				settings.Mode = mode;

			return settings;
		}

		#endregion
	}
}