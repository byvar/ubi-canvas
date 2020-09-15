using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_DynamicStoreContent : CSerializable {
		public CArray<Generic<RLC_DynamicStoreItem>> storeItems;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			storeItems = s.SerializeObject<CArray<Generic<RLC_DynamicStoreItem>>>(storeItems, name: "storeItems");
		}
	}
}

