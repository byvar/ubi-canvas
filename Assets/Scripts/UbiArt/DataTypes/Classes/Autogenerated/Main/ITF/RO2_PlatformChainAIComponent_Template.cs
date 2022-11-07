namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlatformChainAIComponent_Template : ActorComponent_Template {
		public uint rollbackDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rollbackDepth = s.Serialize<uint>(rollbackDepth, name: "rollbackDepth");
		}
		public override uint? ClassCRC => 0x994CCDE2;
	}
}

