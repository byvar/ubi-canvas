using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RedWizardAIComponent_Template : Ray_GroundAIComponent_Template {
		public float followDetectDistance;
		public Placeholder followBehavior;
		public Placeholder eventTriggeredBehaviors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			followDetectDistance = s.Serialize<float>(followDetectDistance, name: "followDetectDistance");
			followBehavior = s.SerializeObject<Placeholder>(followBehavior, name: "followBehavior");
			eventTriggeredBehaviors = s.SerializeObject<Placeholder>(eventTriggeredBehaviors, name: "eventTriggeredBehaviors");
		}
		public override uint? ClassCRC => 0x08D139D7;
	}
}

