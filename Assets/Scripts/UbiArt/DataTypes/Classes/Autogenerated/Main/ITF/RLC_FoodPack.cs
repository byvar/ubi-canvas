namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_FoodPack : RLC_DynamicStoreItem {
		public uint Price;
		public uint FoodAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<uint>(Price, name: "Price");
			FoodAmount = s.Serialize<uint>(FoodAmount, name: "FoodAmount");
		}
		public override uint? ClassCRC => 0xA9590AA5;
	}
}

