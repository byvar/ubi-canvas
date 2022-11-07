namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class Target : CSerializable {
		public CMap<StringID, Action> targets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targets = s.SerializeObject<CMap<StringID, Action>>(targets, name: "targets");
		}
	}
}

