using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_OldTVParam : CSerializable {
		[Serialize("use"          )] public bool use;
		[Serialize("lineFade"     )] public float lineFade;
		[Serialize("useScanLine"  )] public bool useScanLine;
		[Serialize("scanLineFade" )] public float scanLineFade;
		[Serialize("scanLineSpeed")] public float scanLineSpeed;
		[Serialize("scanLineSize" )] public float scanLineSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
				SerializeField(s, nameof(lineFade));
				SerializeField(s, nameof(useScanLine), boolAsByte: true);
				SerializeField(s, nameof(scanLineFade));
				SerializeField(s, nameof(scanLineSpeed));
				SerializeField(s, nameof(scanLineSize));
			} else {
				SerializeField(s, nameof(use));
				SerializeField(s, nameof(lineFade));
				SerializeField(s, nameof(useScanLine));
				SerializeField(s, nameof(scanLineFade));
				SerializeField(s, nameof(scanLineSpeed));
				SerializeField(s, nameof(scanLineSize));
			}
		}
	}
}

