namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AICornBehavior_Template : TemplateAIBehavior {
		public Angle randomAngle;
		public Generic<AIAction_Template> jumpAction;
		public Generic<AIAction_Template> burnAction;
		public Generic<AIAction_Template> popAction;
		public Generic<RO2_AICornFloatAction_Template> floatAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			randomAngle = s.SerializeObject<Angle>(randomAngle, name: "randomAngle");
			jumpAction = s.SerializeObject<Generic<AIAction_Template>>(jumpAction, name: "jumpAction");
			burnAction = s.SerializeObject<Generic<AIAction_Template>>(burnAction, name: "burnAction");
			popAction = s.SerializeObject<Generic<AIAction_Template>>(popAction, name: "popAction");
			floatAction = s.SerializeObject<Generic<RO2_AICornFloatAction_Template>>(floatAction, name: "floatAction");
		}
		public override uint? ClassCRC => 0xD0BB5CE9;
	}
}

