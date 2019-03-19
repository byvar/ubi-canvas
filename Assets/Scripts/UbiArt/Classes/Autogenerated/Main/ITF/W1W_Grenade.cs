using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Grenade : W1W_ThrowableObject {
		[Serialize("float__0"     )] public float float__0;
		[Serialize("bool__1"      )] public bool bool__1;
		[Serialize("bool__2"      )] public bool bool__2;
		[Serialize("bool__3"      )] public bool bool__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("float__5"     )] public float float__5;
		[Serialize("float__6"     )] public float float__6;
		[Serialize("float__7"     )] public float float__7;
		[Serialize("float__8"     )] public float float__8;
		[Serialize("float__9"     )] public float float__9;
		[Serialize("float__10"    )] public float float__10;
		[Serialize("float__11"    )] public float float__11;
		[Serialize("Angle__12"    )] public Angle Angle__12;
		[Serialize("Angle__13"    )] public Angle Angle__13;
		[Serialize("float__14"    )] public float float__14;
		[Serialize("float__15"    )] public float float__15;
		[Serialize("float__16"    )] public float float__16;
		[Serialize("float__17"    )] public float float__17;
		[Serialize("StringID__18" )] public StringID StringID__18;
		[Serialize("float__19"    )] public float float__19;
		[Serialize("Vector2__20"  )] public Vector2 Vector2__20;
		[Serialize("Enum_VH_0__21")] public Enum_VH_0 Enum_VH_0__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(float__10));
			SerializeField(s, nameof(float__11));
			SerializeField(s, nameof(Angle__12));
			SerializeField(s, nameof(Angle__13));
			SerializeField(s, nameof(float__14));
			SerializeField(s, nameof(float__15));
			SerializeField(s, nameof(float__16));
			SerializeField(s, nameof(float__17));
			SerializeField(s, nameof(StringID__18));
			SerializeField(s, nameof(float__19));
			SerializeField(s, nameof(Vector2__20));
			SerializeField(s, nameof(Enum_VH_0__21));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xB22D7F78;
	}
}

