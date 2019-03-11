using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_MosaicParam : CSerializable {
		[Serialize("use"      )] public bool use;
		[Serialize("pixelSize")] public float pixelSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(pixelSize));
		}
	}
}

