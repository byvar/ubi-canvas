using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIFriendly_JumpToTargetBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("jump")] public Placeholder jump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jump));
		}
		public override uint? ClassCRC => 0xF1567739;
	}
}

