using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTree<T> : CSerializable {
		[Serialize("nodes"         )] public CList<Generic<BlendTreeNode<T>>> nodes;
		[Serialize("transitions"   )] public CList<BlendTreeTransition<T>> transitions;
		[Serialize("additiveLayers")] public CList<AdditiveLayer<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(transitions));
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(additiveLayers));
			}
		}
		public override uint? ClassCRC => 0x3B47A4C6;
	}
}

