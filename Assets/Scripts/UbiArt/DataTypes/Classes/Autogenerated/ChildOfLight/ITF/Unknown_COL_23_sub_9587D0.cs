namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_23_sub_9587D0 : CSerializable {
		public float zoffset;
		public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			zoffset = s.Serialize<float>(zoffset, name: "zoffset");
			index = s.Serialize<uint>(index, name: "index");
		}
		public override uint? ClassCRC => 0x9C7EABBB;
	}
}

