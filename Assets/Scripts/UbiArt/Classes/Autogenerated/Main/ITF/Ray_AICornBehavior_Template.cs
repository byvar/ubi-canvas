using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AICornBehavior_Template : TemplateAIBehavior {
		[Serialize("randomAngle")] public Angle randomAngle;
		[Serialize("jumpAction" )] public Generic<AIAction_Template> jumpAction;
		[Serialize("burnAction" )] public Generic<AIAction_Template> burnAction;
		[Serialize("popAction"  )] public Generic<AIAction_Template> popAction;
		[Serialize("floatAction")] public Generic<Ray_AICornFloatAction_Template> floatAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(randomAngle));
			SerializeField(s, nameof(jumpAction));
			SerializeField(s, nameof(burnAction));
			SerializeField(s, nameof(popAction));
			SerializeField(s, nameof(floatAction));
		}
		public override uint? ClassCRC => 0x63543FF0;
	}
}

