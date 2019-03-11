using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_FoodStock : RLC_InventoryItem {
		[Serialize("foodType")] public Creature_Food foodType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(foodType));
		}
		public enum Creature_Food {
			[Serialize("Creature_Food::cookie" )] cookie = 0,
			[Serialize("Creature_Food::pizza"  )] pizza = 1,
			[Serialize("Creature_Food::plum"   )] plum = 2,
			[Serialize("Creature_Food::donut"  )] donut = 3,
			[Serialize("Creature_Food::pancake")] pancake = 4,
		}
		public override uint? ClassCRC => 0xE23F6DE5;
	}
}

