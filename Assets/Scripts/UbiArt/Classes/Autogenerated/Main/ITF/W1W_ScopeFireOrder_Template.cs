using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ScopeFireOrder_Template : ActorComponent_Template {
		[Serialize("Vector2__0")] public Vec2d Vector2__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("float__2"  )] public float float__2;
		[Serialize("float__3"  )] public float float__3;
		[Serialize("float__4"  )] public float float__4;
		[Serialize("float__5"  )] public float float__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector2__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
		}
		public override uint? ClassCRC => 0xAE871D05;
	}
}

