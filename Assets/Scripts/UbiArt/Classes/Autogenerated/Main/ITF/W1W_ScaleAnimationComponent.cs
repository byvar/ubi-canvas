using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ScaleAnimationComponent : ActorComponent {
		[Serialize("Vector2__0")] public Vec2d Vector2__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("Vector2__2")] public Vec2d Vector2__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector2__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(Vector2__2));
		}
		public override uint? ClassCRC => 0x6DE004A5;
	}
}

