using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_PhoenixGadget_Template : Ray_PowerUpDisplay_Template {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("Vector2__2" )] public Vector2 Vector2__2;
		[Serialize("float__3"   )] public float float__3;
		[Serialize("float__4"   )] public float float__4;
		[Serialize("float__5"   )] public float float__5;
		[Serialize("float__6"   )] public float float__6;
		[Serialize("float__7"   )] public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(Vector2__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
		}
		public override uint? ClassCRC => 0xF3550979;
	}
}

