using UnityEngine;

namespace UbiArt.ITF {
	public partial class BehaviorTree_Template : CSerializable {
		[Serialize("root" )] public BTNodeTemplate_Ref root;
		[Serialize("nodes")] public CArray<Generic<BTNode_Template>> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(root));
			SerializeField(s, nameof(nodes));
		}
	}
}

