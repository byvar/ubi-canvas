using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AIRoamingBehavior_Template : TemplateAIBehavior {
		[Serialize("idle")] public Generic<AIIdleAction_Template> idle;
		[Serialize("walk")] public Generic<AIWalkInDirAction_Template> walk;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(walk));
		}
		public override uint? ClassCRC => 0xDC60F442;
	}
}

