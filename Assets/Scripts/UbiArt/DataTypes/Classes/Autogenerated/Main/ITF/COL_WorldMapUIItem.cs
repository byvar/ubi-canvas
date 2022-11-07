namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WorldMapUIItem : CSerializable {
		[Description("Map Location StringID.")]
		public StringID mapLocationID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapLocationID = s.SerializeObject<StringID>(mapLocationID, name: "mapLocationID");
		}
		public override uint? ClassCRC => 0x491A246D;
	}
}

