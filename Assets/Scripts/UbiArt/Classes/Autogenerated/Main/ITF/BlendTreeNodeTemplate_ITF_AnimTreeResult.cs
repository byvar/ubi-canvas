using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeTemplate<AnimTreeResult> : CSerializable {
		[Serialize("nodeName")] public StringID nodeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodeName));
		}
		public override uint? ClassCRC => 0x61D64AC7;
	}
}

