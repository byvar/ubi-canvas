using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTemplate<T> : CSerializable {
		[Serialize("nodes"          )] public CList<Generic<BlendTreeNodeTemplate<T>>> nodes;
		[Serialize("nodeTransitions")] public CList<BlendTreeTransition_Template<T>> nodeTransitions;
		[Serialize("additiveLayers" )] public CList<AdditiveLayer_Template<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(nodeTransitions));
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(additiveLayers));
			}
		}
		public override uint? ClassCRC => 0x91616057;
	}
}

