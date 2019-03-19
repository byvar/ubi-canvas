using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Obus_Template : ActorComponent_Template {
		[Serialize("Path__0"                   )] public Path Path__0;
		[Serialize("float__1"                  )] public float float__1;
		[Serialize("GFXMaterialSerializable__2")] public GFXMaterialSerializable GFXMaterialSerializable__2;
		[Serialize("Curve2D__3"                )] public Curve2D Curve2D__3;
		[Serialize("Curve2D__4"                )] public Curve2D Curve2D__4;
		[Serialize("bool__5"                   )] public bool bool__5;
		[Serialize("float__6"                  )] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(Path__0));
			}
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(GFXMaterialSerializable__2));
			SerializeField(s, nameof(Curve2D__3));
			SerializeField(s, nameof(Curve2D__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(float__6));
		}
		public override uint? ClassCRC => 0x15EADA71;
	}
}

