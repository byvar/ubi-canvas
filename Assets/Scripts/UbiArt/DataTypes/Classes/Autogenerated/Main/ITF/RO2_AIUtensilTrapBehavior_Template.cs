namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIUtensilTrapBehavior_Template : TemplateAIBehavior {
		public float stickOffset;
		public float speed;
		public Generic<AIAction_Template> trapAction;
		public Generic<AIAction_Template> launchAction;
		public Generic<AIAction_Template> flyAction;
		public Generic<AIAction_Template> stickAction;
		public Generic<AIAction_Template> platformAction;
		public bool assignRewardToActivator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stickOffset = s.Serialize<float>(stickOffset, name: "stickOffset");
			speed = s.Serialize<float>(speed, name: "speed");
			trapAction = s.SerializeObject<Generic<AIAction_Template>>(trapAction, name: "trapAction");
			launchAction = s.SerializeObject<Generic<AIAction_Template>>(launchAction, name: "launchAction");
			flyAction = s.SerializeObject<Generic<AIAction_Template>>(flyAction, name: "flyAction");
			stickAction = s.SerializeObject<Generic<AIAction_Template>>(stickAction, name: "stickAction");
			platformAction = s.SerializeObject<Generic<AIAction_Template>>(platformAction, name: "platformAction");
			assignRewardToActivator = s.Serialize<bool>(assignRewardToActivator, name: "assignRewardToActivator");
		}
		public override uint? ClassCRC => 0xBB74E226;
	}
}

