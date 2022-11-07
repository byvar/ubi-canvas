namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AIUmbrellaBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> openAction;
		public Generic<AIAction_Template> closedAction;
		public Generic<AIAction_Template> openingAction;
		public Generic<AIAction_Template> closingAction;
		public Generic<AIAction_Template> warningAction;
		public float closedStateTime;
		public float warningStateTime;
		public float weightThreshold;
		public int closeWithWeight;
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
			closeWithWeight = s.Serialize<int>(closeWithWeight, name: "closeWithWeight");
		}
		public override uint? ClassCRC => 0x59A2B301;
	}
}

