using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class PhaseData : CSerializable {
		public bool bool__0;
		public Enum_VH_0 Enum_VH_0__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public bool bool__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		public bool bool__11;
		public Enum_VH_1 Enum_VH_1__12;
		public float float__13;
		public float float__14;
		public float float__15;
		public float float__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			float__10 = s.Serialize<float>(float__10, name: "float__10");
			bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
			Enum_VH_1__12 = s.Serialize<Enum_VH_1>(Enum_VH_1__12, name: "Enum_VH_1__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
			float__14 = s.Serialize<float>(float__14, name: "float__14");
			float__15 = s.Serialize<float>(float__15, name: "float__15");
			float__16 = s.Serialize<float>(float__16, name: "float__16");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

