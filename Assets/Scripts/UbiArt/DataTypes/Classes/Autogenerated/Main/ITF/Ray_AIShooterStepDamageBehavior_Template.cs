namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIShooterStepDamageBehavior_Template : TemplateAIBehavior {
		public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stepDamageList = s.SerializeObject<Placeholder>(stepDamageList, name: "stepDamageList");
		}
		public override uint? ClassCRC => 0xA9B7DFCD;
	}
}

