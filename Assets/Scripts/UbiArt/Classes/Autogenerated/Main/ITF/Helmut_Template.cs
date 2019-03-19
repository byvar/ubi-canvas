using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Helmut_Template : Npc_Template {
		[Serialize("WithAnimStateMachine_Template__0")] public WithAnimStateMachine_Template WithAnimStateMachine_Template__0;
		[Serialize("float__1"                        )] public float float__1_;
		[Serialize("float__2"                        )] public float float__2_;
		[Serialize("float__3"                        )] public float float__3_;
		[Serialize("float__4"                        )] public float float__4_;
		[Serialize("float__5"                        )] public float float__5_;
		[Serialize("float__6"                        )] public float float__6_;
		[Serialize("float__7"                        )] public float float__7;
		[Serialize("float__8"                        )] public float float__8;
		[Serialize("float__9"                        )] public float float__9;
		[Serialize("Vector2__10"                     )] public Vector2 Vector2__10;
		[Serialize("float__11"                       )] public float float__11;
		[Serialize("float__12"                       )] public float float__12;
		[Serialize("float__13"                       )] public float float__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WithAnimStateMachine_Template__0));
			SerializeField(s, nameof(float__1_));
			SerializeField(s, nameof(float__2_));
			SerializeField(s, nameof(float__3_));
			SerializeField(s, nameof(float__4_));
			SerializeField(s, nameof(float__5_));
			SerializeField(s, nameof(float__6_));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(Vector2__10));
			SerializeField(s, nameof(float__11));
			SerializeField(s, nameof(float__12));
			SerializeField(s, nameof(float__13));
		}
		public override uint? ClassCRC => 0xA76C965E;
	}
}

