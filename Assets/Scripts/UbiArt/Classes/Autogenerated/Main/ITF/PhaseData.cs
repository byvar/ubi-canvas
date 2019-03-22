using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class PhaseData : CSerializable {
		[Serialize("bool__0"      )] public bool bool__0;
		[Serialize("Enum_VH_0__1" )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("float__2"     )] public float float__2;
		[Serialize("float__3"     )] public float float__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("float__5"     )] public float float__5;
		[Serialize("bool__6"      )] public bool bool__6;
		[Serialize("float__7"     )] public float float__7;
		[Serialize("float__8"     )] public float float__8;
		[Serialize("float__9"     )] public float float__9;
		[Serialize("float__10"    )] public float float__10;
		[Serialize("bool__11"     )] public bool bool__11;
		[Serialize("Enum_VH_1__12")] public Enum_VH_1 Enum_VH_1__12;
		[Serialize("float__13"    )] public float float__13;
		[Serialize("float__14"    )] public float float__14;
		[Serialize("float__15"    )] public float float__15;
		[Serialize("float__16"    )] public float float__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(Enum_VH_0__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(bool__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(float__10));
			SerializeField(s, nameof(bool__11));
			SerializeField(s, nameof(Enum_VH_1__12));
			SerializeField(s, nameof(float__13));
			SerializeField(s, nameof(float__14));
			SerializeField(s, nameof(float__15));
			SerializeField(s, nameof(float__16));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

