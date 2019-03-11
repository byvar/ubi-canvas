using UnityEngine;

namespace UbiArt.online {
	public partial class StoreItemSettings : CSerializable {
		[Serialize("price"   )] public uint price;
		[Serialize("quantity")] public uint quantity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(price));
			SerializeField(s, nameof(quantity));
		}
	}
}

