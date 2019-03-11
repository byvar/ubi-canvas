using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTNodeTemplate_Ref : CSerializable {
		[Serialize("nameId")] public StringID nameId;
		[Serialize("node"  )] public Generic<BTNode_Template> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nameId));
			SerializeField(s, nameof(node));
		}
	}
}

