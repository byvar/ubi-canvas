using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_OldTVParam : CSerializable {
		[Serialize("use"          )] public bool use;
		[Serialize("lineFade"     )] public float lineFade;
		[Serialize("useScanLine"  )] public bool useScanLine;
		[Serialize("scanLineFade" )] public float scanLineFade;
		[Serialize("scanLineSpeed")] public float scanLineSpeed;
		[Serialize("scanLineSize" )] public float scanLineSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(lineFade));
			SerializeField(s, nameof(useScanLine));
			SerializeField(s, nameof(scanLineFade));
			SerializeField(s, nameof(scanLineSpeed));
			SerializeField(s, nameof(scanLineSize));
		}
	}
}

