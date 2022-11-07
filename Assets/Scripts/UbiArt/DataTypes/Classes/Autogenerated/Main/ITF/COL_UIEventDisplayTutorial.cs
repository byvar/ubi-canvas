namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIEventDisplayTutorial : CSerializable {
		public uint sender;
		public StringID tutorialID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
			tutorialID = s.SerializeObject<StringID>(tutorialID, name: "tutorialID");
		}
		public override uint? ClassCRC => 0xADEF30F4;
	}
}

