using UnityEngine;

namespace UbiArt.ITF {
	public partial class BehaviorTree : CSerializable {
		[Serialize("root")] public Generic<BTNode> root;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(root));
		}
	}
}

