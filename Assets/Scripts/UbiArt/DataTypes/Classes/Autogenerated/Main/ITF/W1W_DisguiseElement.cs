using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DisguiseElement : W1W_InteractiveGenComponent {
		public Enum_VH_0_1 Enum_VH_0__0_;
		public StringID StringID__1_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0_ = s.Serialize<Enum_VH_0_1>(Enum_VH_0__0_, name: "Enum_VH_0__0");
			StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1");
		}
		public enum Enum_VH_0_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0xD9EAB9BC;
	}
}

