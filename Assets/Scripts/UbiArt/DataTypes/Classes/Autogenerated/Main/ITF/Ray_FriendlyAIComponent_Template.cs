namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyAIComponent_Template : Ray_GroundAIComponent_Template {
		public Generic<TemplateAIBehavior> waitBehavior;
		public Generic<TemplateAIBehavior> triggerBehavior;
		public Generic<TemplateAIBehavior> exitBehavior;
		public Generic<TemplateAIBehavior> pedestalBehavior;
		public Generic<TemplateAIBehavior> jumpBehavior;
		public Generic<TemplateAIBehavior> gotoBehavior;
		public Generic<TemplateAIBehavior> followBehavior;
		public Generic<TemplateAIBehavior> danceBehavior;
		public float followDetectDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(waitBehavior, name: "waitBehavior");
			triggerBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(triggerBehavior, name: "triggerBehavior");
			exitBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(exitBehavior, name: "exitBehavior");
			pedestalBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(pedestalBehavior, name: "pedestalBehavior");
			jumpBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(jumpBehavior, name: "jumpBehavior");
			gotoBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(gotoBehavior, name: "gotoBehavior");
			followBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(followBehavior, name: "followBehavior");
			danceBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(danceBehavior, name: "danceBehavior");
			followDetectDistance = s.Serialize<float>(followDetectDistance, name: "followDetectDistance");
		}
		public override uint? ClassCRC => 0x246AC14F;
	}
}

