namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIJanodTweenedBehavior_Template : Ray_AIJanodRoamingBaseBehavior_Template {
		public float stimFeedback;
		public float stimFeedbackDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stimFeedback = s.Serialize<float>(stimFeedback, name: "stimFeedback");
			stimFeedbackDist = s.Serialize<float>(stimFeedbackDist, name: "stimFeedbackDist");
		}
		public override uint? ClassCRC => 0x03DC6984;
	}
}

