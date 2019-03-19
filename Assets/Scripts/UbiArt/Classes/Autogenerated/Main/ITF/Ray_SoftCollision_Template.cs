using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_SoftCollision_Template : CSerializable {
		[Serialize("float__0"  )] public float float__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("float__2"  )] public float float__2;
		[Serialize("Vector2__3")] public Vector2 Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Vector2__3));
		}
	}
}

