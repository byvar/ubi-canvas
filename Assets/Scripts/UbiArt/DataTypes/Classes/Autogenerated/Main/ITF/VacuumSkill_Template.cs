using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class VacuumSkill_Template : CSerializable {
		public PhysForceModifier PhysForceModifier__0;
		public float float__1;
		public uint uint__2;
		public uint uint__3;
		public int int__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PhysForceModifier__0 = s.SerializeObject<PhysForceModifier>(PhysForceModifier__0, name: "PhysForceModifier__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
			int__4 = s.Serialize<int>(int__4, name: "int__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
		}
	}
}

