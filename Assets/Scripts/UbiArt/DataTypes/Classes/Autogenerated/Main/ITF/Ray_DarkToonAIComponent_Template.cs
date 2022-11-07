namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkToonAIComponent_Template : Ray_GroundAIComponent_Template {
		public Placeholder windBehavior;
		public Placeholder waterBehavior;
		public Placeholder launchBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			windBehavior = s.SerializeObject<Placeholder>(windBehavior, name: "windBehavior");
			waterBehavior = s.SerializeObject<Placeholder>(waterBehavior, name: "waterBehavior");
			launchBehavior = s.SerializeObject<Placeholder>(launchBehavior, name: "launchBehavior");
		}
		public override uint? ClassCRC => 0xF3A80B9B;
	}
}

