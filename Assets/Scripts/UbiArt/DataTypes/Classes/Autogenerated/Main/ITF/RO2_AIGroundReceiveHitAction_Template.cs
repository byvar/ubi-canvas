namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIGroundReceiveHitAction_Template : RO2_AIReceiveHitAction_Template {
		public float unstickMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unstickMultiplier = s.Serialize<float>(unstickMultiplier, name: "unstickMultiplier");
		}
		public override uint? ClassCRC => 0x5AAADA27;
	}
}

