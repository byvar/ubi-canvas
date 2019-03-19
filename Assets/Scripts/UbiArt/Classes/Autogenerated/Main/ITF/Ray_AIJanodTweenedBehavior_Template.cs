using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIJanodTweenedBehavior_Template : Ray_AIJanodRoamingBaseBehavior_Template {
		[Serialize("stimFeedback"    )] public float stimFeedback;
		[Serialize("stimFeedbackDist")] public float stimFeedbackDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stimFeedback));
			SerializeField(s, nameof(stimFeedbackDist));
		}
		public override uint? ClassCRC => 0x03DC6984;
	}
}

