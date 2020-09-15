using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_OldTVParam : CSerializable {
		public bool use;
		public float lineFade;
		public bool useScanLine;
		public float scanLineFade;
		public float scanLineSpeed;
		public float scanLineSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
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

