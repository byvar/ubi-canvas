using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchPolylineComponent : BezierBranchComponent {
		[Serialize("polylineMode")] public PolylineMode polylineMode;
		[Serialize("polylineMode")] public Enum_polylineMode polylineMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(polylineMode));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(polylineMode));
				}
			}
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None"       )] None = 0,
			[Serialize("PolylineMode_Left"       )] Left = 1,
			[Serialize("PolylineMode_Right"      )] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public enum Enum_polylineMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x2D2BC4A8;
	}
}

