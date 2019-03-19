using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_InventoryContent : CSerializable {
		[Serialize("items")] public CMap<uint, RLC_InventoryItem> items;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(items));
		}
	}
}

