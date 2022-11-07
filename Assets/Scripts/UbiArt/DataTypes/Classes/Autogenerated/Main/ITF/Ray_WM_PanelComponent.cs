namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_PanelComponent : CSerializable {
		public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tag = s.SerializeObject<StringID>(tag, name: "tag");
		}
		public override uint? ClassCRC => 0x3F4A4919;
	}
}

