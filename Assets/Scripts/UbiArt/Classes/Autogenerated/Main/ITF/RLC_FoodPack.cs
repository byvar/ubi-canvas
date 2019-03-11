using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_FoodPack : RLC_DynamicStoreItem {
		[Serialize("Price"     )] public uint Price;
		[Serialize("FoodAmount")] public uint FoodAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(FoodAmount));
		}
		public override uint? ClassCRC => 0xA9590AA5;
	}
}

