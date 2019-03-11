using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_DynamicStoreContent : CSerializable {
		[Serialize("storeItems")] public CArray<Generic<RLC_DynamicStoreItem>> storeItems;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(storeItems));
		}
	}
}

