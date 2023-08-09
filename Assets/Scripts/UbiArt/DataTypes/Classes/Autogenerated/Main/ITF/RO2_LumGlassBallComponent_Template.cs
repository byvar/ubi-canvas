namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumGlassBallComponent_Template : ActorComponent_Template {
		public uint LumNumberReward = 5;
		public uint FrameNbTransition = 5;
		public StringID landFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LumNumberReward = s.Serialize<uint>(LumNumberReward, name: "LumNumberReward");
			FrameNbTransition = s.Serialize<uint>(FrameNbTransition, name: "FrameNbTransition");
			landFX = s.SerializeObject<StringID>(landFX, name: "landFX");
		}
		public override uint? ClassCRC => 0x466D4C64;
	}
}

