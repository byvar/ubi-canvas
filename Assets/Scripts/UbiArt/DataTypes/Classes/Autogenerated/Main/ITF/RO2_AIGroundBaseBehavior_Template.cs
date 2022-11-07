namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_AIGroundBaseBehavior_Template : TemplateAIBehavior {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x807B562C;
	}
}

