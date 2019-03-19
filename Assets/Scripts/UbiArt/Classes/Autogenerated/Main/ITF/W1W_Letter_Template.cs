using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Letter_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("float__0"  )] public float float__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("bool__2"   )] public bool bool__2;
		[Serialize("Vector2__3")] public Vector2 Vector2__3;
		[Serialize("Vector2__4")] public Vector2 Vector2__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(Vector2__3));
			SerializeField(s, nameof(Vector2__4));
		}
		public override uint? ClassCRC => 0x59FC70E4;
	}
}

