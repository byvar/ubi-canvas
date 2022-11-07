namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_InventoryItem : CSerializable {
		public uint itemId;
		public uint amount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			itemId = s.Serialize<uint>(itemId, name: "itemId");
			amount = s.Serialize<uint>(amount, name: "amount");
		}
		public override uint? ClassCRC => 0x24E8388C;
	}
}

