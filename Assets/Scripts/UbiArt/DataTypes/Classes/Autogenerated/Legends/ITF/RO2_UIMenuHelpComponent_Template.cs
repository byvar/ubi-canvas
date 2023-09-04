namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuHelpComponent_Template : UIMenuBasic_Template {
		public SmartLocId lastPageItemText;
		public CListO<StringID> subMenuNames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lastPageItemText = s.SerializeObject<SmartLocId>(lastPageItemText, name: "lastPageItemText");
			subMenuNames = s.SerializeObject<CListO<StringID>>(subMenuNames, name: "subMenuNames");
		}
		public override uint? ClassCRC => 0x25F80892;
	}
}

