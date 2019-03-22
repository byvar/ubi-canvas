using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DraggableObject_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("Enum_VH_1__1")] public Enum_VH_0 Enum_VH_0__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(Enum_VH_0__1));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x7ACBFEDA;
	}
}

