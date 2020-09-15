using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BossMorayNodeComponent : ActorComponent {
		public float float__0;
		public float float__1;
		public int int__2;
		public Enum_RFR_0 Enum_RFR_0__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					float__0 = s.Serialize<float>(float__0, name: "float__0");
					float__1 = s.Serialize<float>(float__1, name: "float__1");
					int__2 = s.Serialize<int>(int__2, name: "int__2");
					Enum_RFR_0__3 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__3, name: "Enum_RFR_0__3");
				}
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x2BBA735D;
	}
}

