using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_EyeFishParam : CSerializable {
		[Serialize("use"   )] public bool use;
		[Serialize("height")] public float height;
		[Serialize("scale" )] public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(scale));
		}
	}
}

