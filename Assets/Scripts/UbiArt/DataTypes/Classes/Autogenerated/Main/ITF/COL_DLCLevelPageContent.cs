namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCLevelPageContent : CSerializable {
		public string baseLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			baseLevel = s.Serialize<string>(baseLevel, name: "baseLevel");
		}
		public override uint? ClassCRC => 0xEEAE6E5C;
	}
}

