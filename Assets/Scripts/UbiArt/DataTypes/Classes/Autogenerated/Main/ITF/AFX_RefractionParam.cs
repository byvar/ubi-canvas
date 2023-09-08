namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH)]
	public partial class AFX_RefractionParam : CSerializable {
		public bool use;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
		}
	}
}

