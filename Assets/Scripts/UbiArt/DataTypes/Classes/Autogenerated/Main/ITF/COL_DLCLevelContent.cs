namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCLevelContent : CSerializable {
		public string map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			map = s.Serialize<string>(map, name: "map");
		}
		public override uint? ClassCRC => 0xDAE24836;
	}
}

