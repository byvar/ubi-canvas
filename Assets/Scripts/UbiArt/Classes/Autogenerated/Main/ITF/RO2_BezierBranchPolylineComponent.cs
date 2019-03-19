using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchPolylineComponent : RO2_BezierBranchComponent {
		[Serialize("polylineMode"        )] public RO2_PolylineMode polylineMode;
		[Serialize("polylineTessellation")] public float polylineTessellation;
		[Serialize("polylineMode"        )] public Enum_polylineMode polylineMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(polylineMode));
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
		public enum Enum_polylineMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x47D2DED3;
	}
}

