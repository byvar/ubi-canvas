using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianNodeAIComponent_Template : CSerializable {
		[Serialize("int__0"    )] public int int__0;
		[Serialize("uint__1"   )] public uint uint__1;
		[Serialize("float__2"  )] public float float__2;
		[Serialize("float__3"  )] public float float__3;
		[Serialize("Vector2__4")] public Vec2d Vector2__4;
		[Serialize("float__5"  )] public float float__5;
		[Serialize("float__6"  )] public float float__6;
		[Serialize("float__7"  )] public float float__7;
		[Serialize("float__8"  )] public float float__8;
		[Serialize("float__9"  )] public float float__9;
		[Serialize("float__10" )] public float float__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(float__10));
		}
		public override uint? ClassCRC => 0x629D749F;
	}
}

