using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DisguiseElement : W1W_InteractiveGenComponent {
		[Serialize("Enum_VH_0__0")] public Enum_VH_0_1 Enum_VH_0__0_;
		[Serialize("StringID__1" )] public StringID StringID__1_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0_));
			SerializeField(s, nameof(StringID__1_));
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

