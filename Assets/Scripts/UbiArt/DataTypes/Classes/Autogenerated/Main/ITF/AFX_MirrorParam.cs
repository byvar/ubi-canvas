namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_MirrorParam : CSerializable {
		public bool use;
		public float offsetX;
		public float offsetY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			offsetX = s.Serialize<float>(offsetX, name: "offsetX");
			offsetY = s.Serialize<float>(offsetY, name: "offsetY");
		}
	}
}

