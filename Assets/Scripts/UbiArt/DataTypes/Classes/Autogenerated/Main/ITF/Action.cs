namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class Action : CSerializable {
		public CMap<StringID, FXControl> actions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actions = s.SerializeObject<CMap<StringID, FXControl>>(actions, name: "actions");
		}
	}
}

