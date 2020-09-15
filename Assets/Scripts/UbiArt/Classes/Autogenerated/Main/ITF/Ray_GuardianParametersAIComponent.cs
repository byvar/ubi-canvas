using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianParametersAIComponent : ActorComponent {
		public uint uint__0;
		public float float__1;
		public float float__2;
		public Enum_RFR_0 Enum_RFR_0__3;
		public float float__4;
		public int int__5;
		public uint uint__6;
		public Enum_RFR_0 Enum_RFR_1__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				Enum_RFR_0__3 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__3, name: "Enum_RFR_0__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				int__5 = s.Serialize<int>(int__5, name: "int__5");
				uint__6 = s.Serialize<uint>(uint__6, name: "uint__6");
				Enum_RFR_1__7 = s.Serialize<Enum_RFR_0>(Enum_RFR_1__7, name: "Enum_RFR_1__7");
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x855077BC;
	}
}

