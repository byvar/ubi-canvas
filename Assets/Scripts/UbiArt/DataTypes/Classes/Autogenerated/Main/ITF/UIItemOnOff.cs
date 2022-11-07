namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class UIItemOnOff : UIItemBasic {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			selectTextStyle = s.Serialize<uint>(selectTextStyle, name: "selectTextStyle"); // Yes, the same field is serialized a second time. Points to the same thing.
			selectAnimMeshVertex = s.SerializeObject<CListO<StringID>>(selectAnimMeshVertex, name: "selectAnimMeshVertex");
		}
		public override uint? ClassCRC => 0x38632292;
	}
}

