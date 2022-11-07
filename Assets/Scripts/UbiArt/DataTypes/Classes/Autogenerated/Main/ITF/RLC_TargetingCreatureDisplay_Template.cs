namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TargetingCreatureDisplay_Template : RLC_PowerUpCreatureDisplay_Template {
		public float targetRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targetRange = s.Serialize<float>(targetRange, name: "targetRange");
		}
		public override uint? ClassCRC => 0x0E07F12C;
	}
}

