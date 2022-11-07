namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRedWizardRoamBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		public Placeholder greet;
		public float greetRange;
		public float greetCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			greet = s.SerializeObject<Placeholder>(greet, name: "greet");
			greetRange = s.Serialize<float>(greetRange, name: "greetRange");
			greetCooldown = s.Serialize<float>(greetCooldown, name: "greetCooldown");
		}
		public override uint? ClassCRC => 0xC9B3A832;
	}
}

