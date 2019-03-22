using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchPolylineComponent : BezierBranchComponent {
		[Serialize("polylineMode")] public PolylineMode polylineMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(polylineMode));
			}
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None"       )] None = 0,
			[Serialize("PolylineMode_Left"       )] Left = 1,
			[Serialize("PolylineMode_Right"      )] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x2D2BC4A8;
	}
}

