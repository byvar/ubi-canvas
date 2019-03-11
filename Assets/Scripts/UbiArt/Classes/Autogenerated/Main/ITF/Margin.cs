using UnityEngine;

namespace UbiArt.ITF {
	public partial class Margin : CSerializable {
		[Serialize("left"  )] public float left;
		[Serialize("right" )] public float right;
		[Serialize("top"   )] public float top;
		[Serialize("bottom")] public float bottom;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(left));
			SerializeField(s, nameof(right));
			SerializeField(s, nameof(top));
			SerializeField(s, nameof(bottom));
		}
	}
}

