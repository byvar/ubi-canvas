namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class StoreItemSettings : CSerializable {
		public uint price;
		public uint quantity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			price = s.Serialize<uint>(price, name: "price");
			quantity = s.Serialize<uint>(quantity, name: "quantity");
		}
	}
}

