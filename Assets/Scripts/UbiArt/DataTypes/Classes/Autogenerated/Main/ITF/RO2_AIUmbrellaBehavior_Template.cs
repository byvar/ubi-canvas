namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIUmbrellaBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> openAction;
		public Generic<AIAction_Template> closedAction;
		public Generic<AIAction_Template> openingAction;
		public Generic<AIAction_Template> closingAction;
		public Generic<AIAction_Template> warningAction;
		public float closedStateTime = 0.5f;
		public float warningStateTime = 1f;
		public float weightThreshold = 0.6f;
		public bool closeWithWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openAction = s.SerializeObject<Generic<AIAction_Template>>(openAction, name: "openAction");
			closedAction = s.SerializeObject<Generic<AIAction_Template>>(closedAction, name: "closedAction");
			openingAction = s.SerializeObject<Generic<AIAction_Template>>(openingAction, name: "openingAction");
			closingAction = s.SerializeObject<Generic<AIAction_Template>>(closingAction, name: "closingAction");
			warningAction = s.SerializeObject<Generic<AIAction_Template>>(warningAction, name: "warningAction");
			closedStateTime = s.Serialize<float>(closedStateTime, name: "closedStateTime");
			warningStateTime = s.Serialize<float>(warningStateTime, name: "warningStateTime");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			closeWithWeight = s.Serialize<bool>(closeWithWeight, name: "closeWithWeight");
		}
		public override uint? ClassCRC => 0x5D3B7B7D;
	}
}

