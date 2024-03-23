namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryRuneDrop_Data : COL_InventoryItemDrop_Data {
		public uint amount;
		public Enum_rarity rarity;
		public Enum_level level;
		public Enum_family family;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			amount = s.Serialize<uint>(amount, name: "amount");
			rarity = s.Serialize<Enum_rarity>(rarity, name: "rarity");
			level = s.Serialize<Enum_level>(level, name: "level");
			family = s.Serialize<Enum_family>(family, name: "family");
		}
		public override uint? ClassCRC => 0x0D6CE7E8;

		public enum Enum_rarity {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_level {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_family {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

