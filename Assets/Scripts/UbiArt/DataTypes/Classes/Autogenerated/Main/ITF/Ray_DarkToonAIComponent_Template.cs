namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkToonAIComponent_Template : Ray_GroundAIComponent_Template {
		public Generic<TemplateAIBehavior> windBehavior;
		public Generic<TemplateAIBehavior> waterBehavior;
		public Generic<TemplateAIBehavior> launchBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			windBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(windBehavior, name: "windBehavior");
			waterBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(waterBehavior, name: "waterBehavior");
			launchBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(launchBehavior, name: "launchBehavior");
		}
		public override uint? ClassCRC => 0xF3A80B9B;
	}
}

