namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_ExitComponent_Template : ActorComponent_Template {
		public float shakeFlagsDistance = 10f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shakeFlagsDistance = s.Serialize<float>(shakeFlagsDistance, name: "shakeFlagsDistance");
		}
		public override uint? ClassCRC => 0x0101F5DF;
	}
}

