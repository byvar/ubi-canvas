using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Helmut_Template : Npc_Template {
		[Serialize("WithAnimStateMachine_Template__0")] public WithAnimStateMachine_Template WithAnimStateMachine_Template__0;
		[Serialize("float__1"                        )] public float float__1;
		[Serialize("float__2"                        )] public float float__2;
		[Serialize("float__3"                        )] public float float__3;
		[Serialize("float__4"                        )] public float float__4;
		[Serialize("float__5"                        )] public float float__5;
		[Serialize("float__6"                        )] public float float__6;
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
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
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

