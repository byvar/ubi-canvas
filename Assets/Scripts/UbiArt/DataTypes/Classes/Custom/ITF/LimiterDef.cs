namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class LimiterDef : CSerializable {
		public StringID name;
		public uint maxInstances;
		public LimiterMode mode;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			maxInstances = s.Serialize<uint>(maxInstances, name: "maxInstances");
			mode = s.Serialize<LimiterMode>(mode, name: "mode");
		}
		public enum LimiterMode {
			[Serialize("LimiterMode_RejectNew"         )] RejectNew = 0,
			[Serialize("LimiterMode_StopOldest"        )] StopOldest = 1,
			[Serialize("LimiterMode_StopLowestVolume"  )] StopLowestVolume = 2,
			[Serialize("LimiterMode_OnlyOnePlaying"    )] OnlyOnePlaying = 3,
			[Serialize("LimiterMode_StopLowestPriority")] StopLowestPriority = 4,
		}
	}
}

