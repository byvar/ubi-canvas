namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_OldTVParam : CSerializable {
		public bool use;
		public float lineFade = 0.5f;
		public bool useScanLine;
		public float scanLineFade = 0.5f;
		public float scanLineSpeed = 2f;
		public float scanLineSize = 0.2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
				lineFade = s.Serialize<float>(lineFade, name: "lineFade");
				useScanLine = s.Serialize<bool>(useScanLine, name: "useScanLine", options: CSerializerObject.Options.BoolAsByte);
				scanLineFade = s.Serialize<float>(scanLineFade, name: "scanLineFade");
				scanLineSpeed = s.Serialize<float>(scanLineSpeed, name: "scanLineSpeed");
				scanLineSize = s.Serialize<float>(scanLineSize, name: "scanLineSize");
			} else {
				use = s.Serialize<bool>(use, name: "use");
				lineFade = s.Serialize<float>(lineFade, name: "lineFade");
				useScanLine = s.Serialize<bool>(useScanLine, name: "useScanLine");
				scanLineFade = s.Serialize<float>(scanLineFade, name: "scanLineFade");
				scanLineSpeed = s.Serialize<float>(scanLineSpeed, name: "scanLineSpeed");
				scanLineSize = s.Serialize<float>(scanLineSize, name: "scanLineSize");
			}
		}
	}
}

