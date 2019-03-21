using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchPolylineComponent : RO2_BezierBranchComponent {
		[Serialize("polylineMode"        )] public RO2_PolylineMode polylineMode;
		[Serialize("polylineMode"        )] public RO2_PolylineMode2 polylineMode2;
		[Serialize("polylineTessellation")] public float polylineTessellation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(polylineMode2));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(polylineMode));
					SerializeField(s, nameof(polylineTessellation));
				}
			}
		}
		public enum RO2_PolylineMode {
			[Serialize("RO2_PolylineMode_None"         )] None = 0,
			[Serialize("RO2_PolylineMode_Left"         )] Left = 1,
			[Serialize("RO2_PolylineMode_Right"        )] Right = 2,
			[Serialize("RO2_PolylineMode_DoubleSided"  )] DoubleSided = 3,
			[Serialize("RO2_PolylineMode_LeftInverted" )] LeftInverted = 4,
			[Serialize("RO2_PolylineMode_RightInverted")] RightInverted = 5,
		}
		public enum RO2_PolylineMode2 {
			[Serialize("RO2_PolylineMode_None"       )] None = 0,
			[Serialize("RO2_PolylineMode_Left"       )] Left = 1,
			[Serialize("RO2_PolylineMode_Right"      )] Right = 2,
			[Serialize("RO2_PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x47D2DED3;
	}
}

