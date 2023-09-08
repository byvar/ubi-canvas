namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class ITF_ParticleGenerator_Template : CSerializable {
		public uint computeAABB;
		public uint useAnim;
		public bool useAnim_ { get => useAnim != 0; set => useAnim = (value ? (uint)1 : 0); }
		public uint loop;
		public Path amvPath;
		public uint useUVRandom;
		public int animstart; //= -1;
		public int animend; //= -1;
		public StringID animname;
		public float AnimUVfreq = 1f;
		public ParticleGeneratorParameters _params;
		public DeviceInfo__Device_Speed ObjectDeviceSpeed = (DeviceInfo__Device_Speed)(-1);
		public PARGEN_ZSORT zSortMode;
		public bool is2D;
		public uint phaseLoopStartIndex;
		public uint phaseLoopStopIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				computeAABB = s.Serialize<uint>(computeAABB, name: "computeAABB");
				useAnim = s.Serialize<uint>(useAnim, name: "useAnim");
				loop = s.Serialize<uint>(loop, name: "loop");
				useUVRandom = s.Serialize<uint>(useUVRandom, name: "useUVRandom");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				AnimUVfreq = s.Serialize<float>(AnimUVfreq, name: "AnimUVfreq");
				_params = s.SerializeObject<ParticleGeneratorParameters>(_params, name: "params");
				is2D = s.Serialize<bool>(is2D, name: "is2D");
			} else if (s.Settings.Game == Game.RL) {
				computeAABB = s.Serialize<uint>(computeAABB, name: "computeAABB");
				useAnim = s.Serialize<uint>(useAnim, name: "useAnim");
				loop = s.Serialize<uint>(loop, name: "loop");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				useUVRandom = s.Serialize<uint>(useUVRandom, name: "useUVRandom");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				AnimUVfreq = s.Serialize<float>(AnimUVfreq, name: "AnimUVfreq");
				_params = s.SerializeObject<ParticleGeneratorParameters>(_params, name: "params");
			} else if (s.Settings.Game == Game.COL) {
				computeAABB = s.Serialize<uint>(computeAABB, name: "computeAABB");
				useAnim = s.Serialize<uint>(useAnim, name: "useAnim");
				loop = s.Serialize<uint>(loop, name: "loop");
				phaseLoopStartIndex = s.Serialize<uint>(phaseLoopStartIndex, name: "phaseLoopStartIndex");
				phaseLoopStopIndex = s.Serialize<uint>(phaseLoopStopIndex, name: "phaseLoopStopIndex");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				useUVRandom = s.Serialize<uint>(useUVRandom, name: "useUVRandom");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				AnimUVfreq = s.Serialize<float>(AnimUVfreq, name: "AnimUVfreq");
				_params = s.SerializeObject<ParticleGeneratorParameters>(_params, name: "params");
				zSortMode = s.Serialize<PARGEN_ZSORT>(zSortMode, name: "zSortMode");
			} else if (s.Settings.Game == Game.VH) {
				computeAABB = s.Serialize<uint>(computeAABB, name: "computeAABB");
				useAnim_ = s.Serialize<bool>(useAnim_, name: "useAnim");
				loop = s.Serialize<uint>(loop, name: "loop");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				useUVRandom = s.Serialize<uint>(useUVRandom, name: "useUVRandom");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				AnimUVfreq = s.Serialize<float>(AnimUVfreq, name: "AnimUVfreq");
				_params = s.SerializeObject<ParticleGeneratorParameters>(_params, name: "params");
				zSortMode = s.Serialize<PARGEN_ZSORT>(zSortMode, name: "zSortMode");
			} else {
				computeAABB = s.Serialize<uint>(computeAABB, name: "computeAABB");
				useAnim_ = s.Serialize<bool>(useAnim_, name: "useAnim");
				loop = s.Serialize<uint>(loop, name: "loop");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				useUVRandom = s.Serialize<uint>(useUVRandom, name: "useUVRandom");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				AnimUVfreq = s.Serialize<float>(AnimUVfreq, name: "AnimUVfreq");
				_params = s.SerializeObject<ParticleGeneratorParameters>(_params, name: "params");
				ObjectDeviceSpeed = s.Serialize<DeviceInfo__Device_Speed>(ObjectDeviceSpeed, name: "ObjectDeviceSpeed");
				zSortMode = s.Serialize<PARGEN_ZSORT>(zSortMode, name: "zSortMode");
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
		public override uint? ClassCRC => 0x3F672664;
	}
}

