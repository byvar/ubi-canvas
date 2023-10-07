namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_BlurParam : CSerializable {
		public bool use;
		public float pixelSize = 2f;
		public bool bigBlur = true;
		public uint pixelSize2 = 2;
		public uint quality;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				if (s.Settings.Game == Game.COL) {
					use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
				} else {
					use = s.Serialize<bool>(use, name: "use");
				}
				pixelSize2 = s.Serialize<uint>(pixelSize2, name: "pixelSize");
				quality = s.Serialize<uint>(quality, name: "quality");
			} else {
				use = s.Serialize<bool>(use, name: "use");
				pixelSize = s.Serialize<float>(pixelSize, name: "pixelSize");
				bigBlur = s.Serialize<bool>(bigBlur, name: "bigBlur");
			}
		}
	}
}

