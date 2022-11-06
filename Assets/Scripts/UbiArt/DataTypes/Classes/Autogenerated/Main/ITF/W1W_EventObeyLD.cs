using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventObeyLD : Event {
		public Enum_VH_0 Enum_VH_0__0;
		public StringID StringID__1;
		public bool bool__2;
		public bool bool__3;
		public float float__4;
		public bool bool__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_9")] Value_9 = 9,
		}
		public override uint? ClassCRC => 0xA81FC857;
	}
}

