using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_InventoryContent : CSerializable {
		public CMap<uint, RLC_InventoryItem> items;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			items = s.SerializeObject<CMap<uint, RLC_InventoryItem>>(items, name: "items");
		}
	}
}

