using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DOGController : ActorComponent {
		[Serialize("float__0"  )] public float float__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("float__2"  )] public float float__2;
		[Serialize("float__3"  )] public float float__3;
		[Serialize("Vector2__4")] public Vector2 Vector2__4;
		[Serialize("Vector2__5")] public Vector2 Vector2__5;
		[Serialize("float__6"  )] public float float__6;
		[Serialize("float__7"  )] public float float__7;
		[Serialize("float__8"  )] public float float__8;
		[Serialize("bool__9"   )] public bool bool__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(Vector2__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(bool__9));
		}
		public override uint? ClassCRC => 0x1AC2A37A;
	}
}

