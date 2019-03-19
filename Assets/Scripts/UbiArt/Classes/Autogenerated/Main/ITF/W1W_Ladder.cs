using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Ladder : W1W_InteractiveGenComponent {
		[Serialize("float__0"    )] public float float__0;
		[Serialize("float__1"    )] public float float__1;
		[Serialize("Enum_VH_0__2")] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("bool__3"     )] public bool bool__3;
		[Serialize("bool__4"     )] public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(Enum_VH_0__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(bool__4));
		}
		public enum Enum_VH_0 {
			[Serialize("Wood" )] Wood = 165615538,
			[Serialize("Metal")] Metal = -1978991762,
		}
		public override uint? ClassCRC => 0xFBE7ADAB;
	}
}

