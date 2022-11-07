namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCComponent_Template : CSerializable {
		public int supportSkin;
		public StringID skinFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			supportSkin = s.Serialize<int>(supportSkin, name: "supportSkin");
			skinFamily = s.SerializeObject<StringID>(skinFamily, name: "skinFamily");
		}
		public override uint? ClassCRC => 0x1C6C1B31;
	}
}

