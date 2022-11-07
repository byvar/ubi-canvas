namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CreditsMenu_Template : CSerializable {
		public Placeholder creditsTexts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creditsTexts = s.SerializeObject<Placeholder>(creditsTexts, name: "creditsTexts");
		}
		public override uint? ClassCRC => 0x327CAF99;
	}
}

