using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class RO2_DigShapeComponent_Template : ActorComponent_Template {
		[Serialize("bool__0"              )] public bool bool__0;
		[Serialize("Vector2__1"           )] public Vector2 Vector2__1;
		[Serialize("Vector2__2"           )] public Vector2 Vector2__2;
		[Serialize("bool__3"              )] public bool bool__3;
		[Serialize("bool__4"              )] public bool bool__4;
		[Serialize("bool__5"              )] public bool bool__5;
		[Serialize("float__6"             )] public float float__6;
		[Serialize("Generic<PhysShape>__7")] public Generic<PhysShape> Generic_PhysShape__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(Vector2__1));
			SerializeField(s, nameof(Vector2__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(bool__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(Generic_PhysShape__7));
		}
		public override uint? ClassCRC => 0x39406FA0;
	}
}

