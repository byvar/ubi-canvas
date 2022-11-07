namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionInventoryItem_Template : CSerializable {
		[Description("item")]
		public StringID itemID;
		public bool add;
		public bool showpopup;
		[Description("quantity")]
		public uint quantity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			itemID = s.SerializeObject<StringID>(itemID, name: "itemID");
			add = s.Serialize<bool>(add, name: "add", options: CSerializerObject.Options.BoolAsByte);
			showpopup = s.Serialize<bool>(showpopup, name: "showpopup", options: CSerializerObject.Options.BoolAsByte);
			quantity = s.Serialize<uint>(quantity, name: "quantity");
		}
		public override uint? ClassCRC => 0xF9DAFB46;
	}
}

