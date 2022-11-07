namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MusicScoreSnapComponent : ActorComponent {
		public float distOnCurve;
		public uint note;
		public float noteIntervalHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				distOnCurve = s.Serialize<float>(distOnCurve, name: "distOnCurve");
				note = s.Serialize<uint>(note, name: "note");
				noteIntervalHeight = s.Serialize<float>(noteIntervalHeight, name: "noteIntervalHeight");
			}
		}
		public override uint? ClassCRC => 0xB76E3E61;
	}
}

