using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiShortcutCollectible : ActorComponent {
		[Serialize("Path__0"   )] public Path Path__0;
		[Serialize("uint__1"   )] public uint uint__1;
		[Serialize("Vector2__2")] public Vector2 Vector2__2;
		[Serialize("Vector2__3")] public Vector2 Vector2__3;
		[Serialize("uint__4"   )] public uint uint__4;
		[Serialize("Path__5"   )] public Path Path__5;
		[Serialize("Vector2__6")] public Vector2 Vector2__6;
		[Serialize("float__7"  )] public float float__7;
		[Serialize("Path__8"   )] public Path Path__8;
		[Serialize("Vector2__9")] public Vector2 Vector2__9;
		[Serialize("bool__10"  )] public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(Vector2__2));
			SerializeField(s, nameof(Vector2__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(Path__5));
			SerializeField(s, nameof(Vector2__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(Path__8));
			SerializeField(s, nameof(Vector2__9));
			SerializeField(s, nameof(bool__10));
		}
		public override uint? ClassCRC => 0xA54374C5;
	}
}

