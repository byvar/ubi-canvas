using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CharDiaNavigation : ActorComponent {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("Path__1"    )] public Path Path__1;
		[Serialize("Path__2"    )] public Path Path__2;
		[Serialize("Path__3"    )] public Path Path__3;
		[Serialize("Vector2__4" )] public Vector2 Vector2__4;
		[Serialize("Vector2__5" )] public Vector2 Vector2__5;
		[Serialize("float__6"   )] public float float__6;
		[Serialize("Vector2__7" )] public Vector2 Vector2__7;
		[Serialize("Path__8"    )] public Path Path__8;
		[Serialize("Path__9"    )] public Path Path__9;
		[Serialize("Path__10"   )] public Path Path__10;
		[Serialize("Path__11"   )] public Path Path__11;
		[Serialize("Path__12"   )] public Path Path__12;
		[Serialize("Vector2__13")] public Vector2 Vector2__13;
		[Serialize("Vector2__14")] public Vector2 Vector2__14;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(Vector2__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(Vector2__7));
			SerializeField(s, nameof(Path__8));
			SerializeField(s, nameof(Path__9));
			SerializeField(s, nameof(Path__10));
			SerializeField(s, nameof(Path__11));
			SerializeField(s, nameof(Path__12));
			SerializeField(s, nameof(Vector2__13));
			SerializeField(s, nameof(Vector2__14));
		}
		public override uint? ClassCRC => 0xD45EB3E3;
	}
}

