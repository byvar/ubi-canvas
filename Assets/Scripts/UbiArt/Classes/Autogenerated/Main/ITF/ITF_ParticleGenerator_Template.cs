using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ITF_ParticleGenerator_Template : CSerializable {
		[Serialize("computeAABB"                   )] public uint computeAABB;
		[Serialize("useAnim"                       )] public bool useAnim;
		[Serialize("loop"                          )] public uint loop;
		[Serialize("amvPath"                       )] public Path amvPath;
		[Serialize("useUVRandom"                   )] public uint useUVRandom;
		[Serialize("animstart"                     )] public int animstart;
		[Serialize("animend"                       )] public int animend;
		[Serialize("animname"                      )] public StringID animname;
		[Serialize("AnimUVfreq"                    )] public float AnimUVfreq;
		[Serialize("params"                        )] public ParticleGeneratorParameters _params;
		[Serialize("ObjectDeviceSpeed"             )] public DeviceInfo__Device_Speed ObjectDeviceSpeed;
		[Serialize("zSortMode"                     )] public PARGEN_ZSORT zSortMode;
		[Serialize("useAnim"                       )] public uint useAnim;
		[Serialize("is2D"                          )] public int is2D;
		[Serialize("phaseLoopStartIndex"           )] public uint phaseLoopStartIndex;
		[Serialize("phaseLoopStopIndex"            )] public uint phaseLoopStopIndex;
		[Serialize("zSortMode"                     )] public Enum_zSortMode zSortMode;
		[Serialize("uint__0"                       )] public uint uint__0;
		[Serialize("bool__1"                       )] public bool bool__1;
		[Serialize("uint__2"                       )] public uint uint__2;
		[Serialize("Path__3"                       )] public Path Path__3;
		[Serialize("uint__4"                       )] public uint uint__4;
		[Serialize("int__5"                        )] public int int__5;
		[Serialize("int__6"                        )] public int int__6;
		[Serialize("StringID__7"                   )] public StringID StringID__7;
		[Serialize("float__8"                      )] public float float__8;
		[Serialize("ParticleGeneratorParameters__9")] public ParticleGeneratorParameters ParticleGeneratorParameters__9;
		[Serialize("Enum_VH_0__10"                 )] public Enum_VH_0 Enum_VH_0__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(computeAABB));
				SerializeField(s, nameof(useAnim));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(useUVRandom));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(AnimUVfreq));
				SerializeField(s, nameof(_params));
				SerializeField(s, nameof(is2D));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(computeAABB));
				SerializeField(s, nameof(useAnim));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(amvPath));
				SerializeField(s, nameof(useUVRandom));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(animname));
				SerializeField(s, nameof(AnimUVfreq));
				SerializeField(s, nameof(_params));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(computeAABB));
				SerializeField(s, nameof(useAnim));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(phaseLoopStartIndex));
				SerializeField(s, nameof(phaseLoopStopIndex));
				SerializeField(s, nameof(amvPath));
				SerializeField(s, nameof(useUVRandom));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(animname));
				SerializeField(s, nameof(AnimUVfreq));
				SerializeField(s, nameof(zSortMode));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(StringID__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(ParticleGeneratorParameters__9));
				SerializeField(s, nameof(Enum_VH_0__10));
			} else {
				SerializeField(s, nameof(computeAABB));
				SerializeField(s, nameof(useAnim));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(amvPath));
				SerializeField(s, nameof(useUVRandom));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(animname));
				SerializeField(s, nameof(AnimUVfreq));
				SerializeField(s, nameof(_params));
				SerializeField(s, nameof(ObjectDeviceSpeed));
				SerializeField(s, nameof(zSortMode));
			}
		}
		public enum DeviceInfo__Device_Speed {
			[Serialize("DeviceInfo::Device_SpeedLow"               )] Low = 1,
			[Serialize("DeviceInfo::Device_SpeedLowMedium"         )] LowMedium = 3,
			[Serialize("DeviceInfo::Device_SpeedLowMediumHigh"     )] LowMediumHigh = 7,
			[Serialize("DeviceInfo::Device_SpeedMedium"            )] Medium = 2,
			[Serialize("DeviceInfo::Device_SpeedMediumHigh"        )] MediumHigh = 6,
			[Serialize("DeviceInfo::Device_SpeedMediumHighVeryHigh")] MediumHighVeryHigh = 14,
			[Serialize("DeviceInfo::Device_SpeedHigh"              )] High = 4,
			[Serialize("DeviceInfo::Device_SpeedHighVeryHigh"      )] HighVeryHigh = 12,
			[Serialize("DeviceInfo::Device_SpeedVeryHigh"          )] VeryHigh = 8,
			[Serialize("DeviceInfo::Device_SpeedAll"               )] All = 15,
		}
		public enum PARGEN_ZSORT {
			[Serialize("PARGEN_ZSORT_NONE"       )] NONE = 0,
			[Serialize("PARGEN_ZSORT_NEWER_FIRST")] NEWER_FIRST = 2,
			[Serialize("PARGEN_ZSORT_OLDER_FIRST")] OLDER_FIRST = 1,
		}
		public enum Enum_zSortMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x3F672664;
	}
}

