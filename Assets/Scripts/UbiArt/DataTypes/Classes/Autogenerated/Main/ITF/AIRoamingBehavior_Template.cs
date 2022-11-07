namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIRoamingBehavior_Template : TemplateAIBehavior {
		public Generic<AIIdleAction_Template> idle;
		public Generic<AIWalkInDirAction_Template> walk;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIIdleAction_Template>>(idle, name: "idle");
			walk = s.SerializeObject<Generic<AIWalkInDirAction_Template>>(walk, name: "walk");
		}
		public override uint? ClassCRC => 0xDC60F442;
	}
}

