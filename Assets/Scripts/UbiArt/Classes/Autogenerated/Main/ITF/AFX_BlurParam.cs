using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_BlurParam : CSerializable {
		[Serialize("use"      )] public bool use;
		[Serialize("pixelSize")] public float pixelSize;
		[Serialize("bigBlur"  )] public bool bigBlur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(pixelSize));
			SerializeField(s, nameof(bigBlur));
		}
	}
}

