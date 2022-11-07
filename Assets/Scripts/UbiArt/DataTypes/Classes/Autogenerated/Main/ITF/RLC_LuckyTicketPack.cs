namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketPack : RLC_DynamicStoreItem {
		public uint Price;
		public uint Amount;
		public bool GoldenTicketPack;
		public uint msdkItemId_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<uint>(Price, name: "Price");
			Amount = s.Serialize<uint>(Amount, name: "Amount");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				GoldenTicketPack = s.Serialize<bool>(GoldenTicketPack, name: "GoldenTicketPack");
			}
			msdkItemId_ = s.Serialize<uint>(msdkItemId_, name: "msdkItemId");
		}
		public override uint? ClassCRC => 0xACECEBCA;
	}
}

