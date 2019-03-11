using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_StoreBundleLocInfo : CSerializable {
		[Serialize("StoreBundleTitle"         )] public string StoreBundleTitle;
		[Serialize("StoreBundlePurchasedTitle")] public string StoreBundlePurchasedTitle;
		[Serialize("StoreBundlePurchasedDesc" )] public string StoreBundlePurchasedDesc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StoreBundleTitle));
			SerializeField(s, nameof(StoreBundlePurchasedTitle));
			SerializeField(s, nameof(StoreBundlePurchasedDesc));
		}
	}
}

