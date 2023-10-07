namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_NoiseParam : CSerializable {
		public bool use;
		public float blendFactor = 0.5f;
		public float size = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			blendFactor = s.Serialize<float>(blendFactor, name: "blendFactor");
			size = s.Serialize<float>(size, name: "size");
		}
	}
}

