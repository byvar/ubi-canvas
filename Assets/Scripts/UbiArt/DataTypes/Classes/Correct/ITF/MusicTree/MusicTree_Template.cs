namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL)]
	public partial class MusicTree_Template : BlendTreeTemplate<MusicTreeResult> {
		public uint metronomeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
		}
		public override uint? ClassCRC => 0x351957B6;
	}
}

