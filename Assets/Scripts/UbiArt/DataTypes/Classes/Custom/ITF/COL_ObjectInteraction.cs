namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_ObjectInteraction : COL_BaseInteraction {
		[Description("Object state from which this interaction can be proposed")]
		public StringID sourceState;
		[Description("Object state where this interaction will lead")]
		public StringID destinationState;
		[Description("Inventory item(s) given when the interaction stop")]
		public CListO<Generic<COL_InventoryItemDrop_Data>> onEndInventoryDrop;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sourceState = s.SerializeObject<StringID>(sourceState, name: "sourceState");
			destinationState = s.SerializeObject<StringID>(destinationState, name: "destinationState");
			onEndInventoryDrop = s.SerializeObject<CListO<Generic<COL_InventoryItemDrop_Data>>>(onEndInventoryDrop, name: "onEndInventoryDrop");
		}
		public override uint? ClassCRC => 0xC8F783F8;
	}
}

