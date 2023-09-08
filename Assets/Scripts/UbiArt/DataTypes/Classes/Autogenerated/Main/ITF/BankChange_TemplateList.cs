namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BankChange_TemplateList : CSerializable {
		public CListO<TextureBankPath> redirectList;
		public CListO<BankChange_Template> redirectList_Origins;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion <= EngineVersion.RO) {
				redirectList_Origins = s.SerializeObject<CListO<BankChange_Template>>(redirectList_Origins, name: "redirectList");
			} else {
				redirectList = s.SerializeObject<CListO<TextureBankPath>>(redirectList, name: "redirectList");
			}
		}
	}
}

