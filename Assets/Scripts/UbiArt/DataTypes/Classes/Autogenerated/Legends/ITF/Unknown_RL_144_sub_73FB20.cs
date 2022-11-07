namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_144_sub_73FB20 : CSerializable {
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

