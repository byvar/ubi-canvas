namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BuzzSawAIComponent_Template : RO2_AIComponent_Template {
		public StringID openAnim;
		public StringID closedAnim;
		public StringID hurtPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			closedAnim = s.SerializeObject<StringID>(closedAnim, name: "closedAnim");
			hurtPolyline = s.SerializeObject<StringID>(hurtPolyline, name: "hurtPolyline");
		}
		public override uint? ClassCRC => 0x3D4CE2D4;
	}
}

