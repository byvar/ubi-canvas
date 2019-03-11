using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AICornBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("randomAngle")] public Angle randomAngle;
		[Serialize("jumpAction" )] public Placeholder jumpAction;
		[Serialize("burnAction" )] public Placeholder burnAction;
		[Serialize("popAction"  )] public Placeholder popAction;
		[Serialize("floatAction")] public Placeholder floatAction;
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

