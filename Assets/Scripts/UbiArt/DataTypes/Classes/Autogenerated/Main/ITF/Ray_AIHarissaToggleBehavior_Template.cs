namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIHarissaToggleBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> offAction;
		public Generic<AIAction_Template> onAction;
		public Generic<AIAction_Template> hitAction;
		public StringID flameFXName;
		public StringID squashedInAnim;
		public StringID squashedLoopAnim;
		public StringID squashedOutAnim;
		public StringID polylineName;
		public float weightThreshold;
		public float flamesDurationOnCrushAttack;
		public float hitActionDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offAction = s.SerializeObject<Generic<AIAction_Template>>(offAction, name: "offAction");
			onAction = s.SerializeObject<Generic<AIAction_Template>>(onAction, name: "onAction");
			hitAction = s.SerializeObject<Generic<AIAction_Template>>(hitAction, name: "hitAction");
			flameFXName = s.SerializeObject<StringID>(flameFXName, name: "flameFXName");
			squashedInAnim = s.SerializeObject<StringID>(squashedInAnim, name: "squashedInAnim");
			squashedLoopAnim = s.SerializeObject<StringID>(squashedLoopAnim, name: "squashedLoopAnim");
			squashedOutAnim = s.SerializeObject<StringID>(squashedOutAnim, name: "squashedOutAnim");
			polylineName = s.SerializeObject<StringID>(polylineName, name: "polylineName");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			flamesDurationOnCrushAttack = s.Serialize<float>(flamesDurationOnCrushAttack, name: "flamesDurationOnCrushAttack");
			hitActionDuration = s.Serialize<float>(hitActionDuration, name: "hitActionDuration");
		}
		public override uint? ClassCRC => 0x060B2E38;
	}
}

