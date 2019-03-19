using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GameAndWatchComponent_Template : ActorComponent_Template {
		[Serialize("Curve2D__0")] public Curve2D Curve2D__0;
		[Serialize("Curve2D__1")] public Curve2D Curve2D__1;
		[Serialize("float__2"  )] public float float__2;
		[Serialize("Color__3"  )] public Color Color__3;
		[Serialize("float__4"  )] public float float__4;
		[Serialize("uint__5"   )] public uint uint__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Curve2D__0));
			SerializeField(s, nameof(Curve2D__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Color__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(uint__5));
		}
		public override uint? ClassCRC => 0x0AAB0AF8;
	}
}

