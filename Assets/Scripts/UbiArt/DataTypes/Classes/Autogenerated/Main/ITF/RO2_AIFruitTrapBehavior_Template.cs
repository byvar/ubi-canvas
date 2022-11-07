namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIFruitTrapBehavior_Template : TemplateAIBehavior {
		public float delay;
		public float weightThreshold;
		public Generic<AIAction_Template> standAction;
		public Generic<AIAction_Template> fruitFallAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			delay = s.Serialize<float>(delay, name: "delay");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			standAction = s.SerializeObject<Generic<AIAction_Template>>(standAction, name: "standAction");
			fruitFallAction = s.SerializeObject<Generic<AIAction_Template>>(fruitFallAction, name: "fruitFallAction");
		}
		public override uint? ClassCRC => 0x56C09D7E;
	}
}

