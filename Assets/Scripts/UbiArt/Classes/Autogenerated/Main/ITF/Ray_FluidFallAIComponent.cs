using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_FluidFallAIComponent : GraphicComponent {
		public Enum_RJR_0 uvMode;
		public int startOpen;
		public float widthStart;
		public float widthBase;
		public float speed;
		public Enum_RFR_0 Enum_RFR_0__0;
		public int int__1;
		public float float__2;
		public float float__3;
		public float float__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				Enum_RFR_0__0 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__0, name: "Enum_RFR_0__0");
				if (s.HasFlags(SerializeFlags.Default)) {
					int__1 = s.Serialize<int>(int__1, name: "int__1");
					float__2 = s.Serialize<float>(float__2, name: "float__2");
					float__3 = s.Serialize<float>(float__3, name: "float__3");
					float__4 = s.Serialize<float>(float__4, name: "float__4");
				}
			} else {
				uvMode = s.Serialize<Enum_RJR_0>(uvMode, name: "uvMode");
				if (s.HasFlags(SerializeFlags.Default)) {
					startOpen = s.Serialize<int>(startOpen, name: "startOpen");
					widthStart = s.Serialize<float>(widthStart, name: "widthStart");
					widthBase = s.Serialize<float>(widthBase, name: "widthBase");
					speed = s.Serialize<float>(speed, name: "speed");
				}
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x7FC096B9;
	}
}

