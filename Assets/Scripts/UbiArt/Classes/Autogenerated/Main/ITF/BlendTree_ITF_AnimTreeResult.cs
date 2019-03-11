using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTree<AnimTreeResult> : CSerializable {
		[Serialize("nodes"         )] public CList<BlendTreeNode<AnimTreeResult>> nodes;
		[Serialize("transitions"   )] public CList<BlendTreeTransition<AnimTreeResult>> transitions;
		[Serialize("additiveLayers")] public CList<AdditiveLayer<AnimTreeResult>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(transitions));
			SerializeField(s, nameof(additiveLayers));
		}
		public override uint? ClassCRC => 0x3B47A4C6;
	}
}

