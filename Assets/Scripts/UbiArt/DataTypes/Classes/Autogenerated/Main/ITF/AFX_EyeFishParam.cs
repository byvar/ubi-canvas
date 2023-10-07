namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_EyeFishParam : CSerializable {
		public bool use;
		public float height = 2f;
		public float scale = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			height = s.Serialize<float>(height, name: "height");
			scale = s.Serialize<float>(scale, name: "scale");
		}
	}
}

