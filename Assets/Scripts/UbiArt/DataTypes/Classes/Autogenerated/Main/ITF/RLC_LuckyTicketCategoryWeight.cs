namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketCategoryWeight : CSerializable {
		public Enum_category category;
		public uint weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			category = s.Serialize<Enum_category>(category, name: "category");
			weight = s.Serialize<uint>(weight, name: "weight");
		}
		public enum Enum_category {
			[Serialize("Normal" )] Normal = 0,
			[Serialize("Jackpot")] Jackpot = 1,
			[Serialize("Egg"    )] Egg = 2,
		}
	}
}

