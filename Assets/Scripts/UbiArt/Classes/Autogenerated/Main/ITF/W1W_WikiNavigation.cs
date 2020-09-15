using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiNavigation : ActorComponent {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("Path__1"    )] public Path Path__1;
		[Serialize("Path__2"    )] public Path Path__2;
		[Serialize("Path__3"    )] public Path Path__3;
		[Serialize("Path__4"    )] public Path Path__4;
		[Serialize("Path__5"    )] public Path Path__5;
		[Serialize("Vector2__6" )] public Vec2d Vector2__6;
		[Serialize("Vector2__7" )] public Vec2d Vector2__7;
		[Serialize("float__8"   )] public float float__8;
		[Serialize("Vector2__9" )] public Vec2d Vector2__9;
		[Serialize("Path__10"   )] public Path Path__10;
		[Serialize("uint__11"   )] public uint uint__11;
		[Serialize("uint__12"   )] public uint uint__12;
		[Serialize("Path__13"   )] public Path Path__13;
		[Serialize("Vector2__14")] public Vec2d Vector2__14;
		[Serialize("Vector2__15")] public Vec2d Vector2__15;
		[Serialize("Vector2__16")] public Vec2d Vector2__16;
		[Serialize("Vector2__17")] public Vec2d Vector2__17;
		[Serialize("Vector2__18")] public Vec2d Vector2__18;
		[Serialize("uint__19"   )] public uint uint__19;
		[Serialize("uint__20"   )] public uint uint__20;
		[Serialize("Vector2__21")] public Vec2d Vector2__21;
		[Serialize("Path__22"   )] public Path Path__22;
		[Serialize("Path__23"   )] public Path Path__23;
		[Serialize("Vector2__24")] public Vec2d Vector2__24;
		[Serialize("float__25"  )] public float float__25;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Path__4));
			SerializeField(s, nameof(Path__5));
			SerializeField(s, nameof(Vector2__6));
			SerializeField(s, nameof(Vector2__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(Vector2__9));
			SerializeField(s, nameof(Path__10));
			SerializeField(s, nameof(uint__11));
			SerializeField(s, nameof(uint__12));
			SerializeField(s, nameof(Path__13));
			SerializeField(s, nameof(Vector2__14));
			SerializeField(s, nameof(Vector2__15));
			SerializeField(s, nameof(Vector2__16));
			SerializeField(s, nameof(Vector2__17));
			SerializeField(s, nameof(Vector2__18));
			SerializeField(s, nameof(uint__19));
			SerializeField(s, nameof(uint__20));
			SerializeField(s, nameof(Vector2__21));
			SerializeField(s, nameof(Path__22));
			SerializeField(s, nameof(Path__23));
			SerializeField(s, nameof(Vector2__24));
			SerializeField(s, nameof(float__25));
		}
		public override uint? ClassCRC => 0x143B9E26;
	}
}

