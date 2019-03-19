using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Grenade_Template : W1W_ThrowableObject_Template {
		[Serialize("float__0"    )] public float float__0;
		[Serialize("Enum_VH_0__1")] public Enum_VH_0 Enum_VH_0__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(Enum_VH_0__1));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xA74E86C8;
	}
}

