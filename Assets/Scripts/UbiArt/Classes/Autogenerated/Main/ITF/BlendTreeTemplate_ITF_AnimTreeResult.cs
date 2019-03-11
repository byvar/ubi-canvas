using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeTemplate<AnimTreeResult> : CSerializable {
		[Serialize("nodes"          )] public CList<BlendTreeNodeTemplate<AnimTreeResult>> nodes;
		[Serialize("nodeTransitions")] public CList<BlendTreeTransition_Template<AnimTreeResult>> nodeTransitions;
		[Serialize("additiveLayers" )] public CList<AdditiveLayer_Template<AnimTreeResult>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(nodeTransitions));
			SerializeField(s, nameof(additiveLayers));
		}
		public override uint? ClassCRC => 0x91616057;
	}
}

