namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LumJarComponent_Template : ActorComponent_Template {
		public uint LumNumberReward;
		public uint FrameNbTransition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LumNumberReward = s.Serialize<uint>(LumNumberReward, name: "LumNumberReward");
			FrameNbTransition = s.Serialize<uint>(FrameNbTransition, name: "FrameNbTransition");
		}
		public override uint? ClassCRC => 0xD0788A27;
	}
}

