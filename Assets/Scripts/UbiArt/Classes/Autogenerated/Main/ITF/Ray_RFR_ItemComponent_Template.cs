using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_ItemComponent_Template : CSerializable {
		[Serialize("Enum_RFR_0__0")] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("Path__1"      )] public Path Path__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_RFR_0__0));
			SerializeField(s, nameof(Path__1));
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xDB6CEC56;
	}
}

