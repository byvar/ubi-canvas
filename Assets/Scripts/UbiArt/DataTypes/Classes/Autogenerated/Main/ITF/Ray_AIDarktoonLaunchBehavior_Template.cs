namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonLaunchBehavior_Template : TemplateAIBehavior {
		public Generic<AIBallisticsAction_Template> ballistics;
		public Generic<AIAction_Template> landing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ballistics = s.SerializeObject<Generic<AIBallisticsAction_Template>>(ballistics, name: "ballistics");
			landing = s.SerializeObject<Generic<AIAction_Template>>(landing, name: "landing");
		}
		public override uint? ClassCRC => 0x20A3A4D8;
	}
}

