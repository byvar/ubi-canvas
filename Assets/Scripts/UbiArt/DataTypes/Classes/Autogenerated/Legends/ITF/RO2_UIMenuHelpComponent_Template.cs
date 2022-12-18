namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuHelpComponent_Template : CSerializable {
		public Placeholder lastPageItemText;
		public Placeholder subMenuNames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lastPageItemText = s.SerializeObject<Placeholder>(lastPageItemText, name: "lastPageItemText");
			subMenuNames = s.SerializeObject<Placeholder>(subMenuNames, name: "subMenuNames");
		}
		public override uint? ClassCRC => 0x25F80892;
	}
}

