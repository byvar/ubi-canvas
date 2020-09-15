using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_IslandEntryComponent : ActorComponent {
		public Enum_RFR_0 Enum_RFR_0__0;
		public int int__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_RFR_0__0 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__0, name: "Enum_RFR_0__0");
			int__1 = s.Serialize<int>(int__1, name: "int__1");
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x2AC2B9DD;
	}
}

