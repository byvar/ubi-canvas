namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_BeatboxSaveSlotPack : RLC_DynamicStoreItem {
		public uint Price;
		public uint Amount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<uint>(Price, name: "Price");
			Amount = s.Serialize<uint>(Amount, name: "Amount");
		}
		public override uint? ClassCRC => 0x46A6D042;
	}
}

