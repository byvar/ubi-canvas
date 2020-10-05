using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIPauseMenuButtonComponent : CSerializable {
		public Enum_buttonType buttonType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buttonType = s.Serialize<Enum_buttonType>(buttonType, name: "buttonType");
		}
		public enum Enum_buttonType {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
		}
		public override uint? ClassCRC => 0xA17B2F54;
	}
}

