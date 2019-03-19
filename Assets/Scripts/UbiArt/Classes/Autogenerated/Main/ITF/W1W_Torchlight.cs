using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Torchlight : ActorComponent {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("Path__1"    )] public Path Path__1;
		[Serialize("Vector3__2" )] public Vector3 Vector3__2;
		[Serialize("Vector2__3" )] public Vector2 Vector2__3;
		[Serialize("Angle__4"   )] public Angle Angle__4;
		[Serialize("Path__5"    )] public Path Path__5;
		[Serialize("Vector3__6" )] public Vector3 Vector3__6;
		[Serialize("Vector2__7" )] public Vector2 Vector2__7;
		[Serialize("Angle__8"   )] public Angle Angle__8;
		[Serialize("Path__9"    )] public Path Path__9;
		[Serialize("Vector3__10")] public Vector3 Vector3__10;
		[Serialize("Vector2__11")] public Vector2 Vector2__11;
		[Serialize("Angle__12"  )] public Angle Angle__12;
		[Serialize("bool__13"   )] public bool bool__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Vector3__2));
			SerializeField(s, nameof(Vector2__3));
			SerializeField(s, nameof(Angle__4));
			SerializeField(s, nameof(Path__5));
			SerializeField(s, nameof(Vector3__6));
			SerializeField(s, nameof(Vector2__7));
			SerializeField(s, nameof(Angle__8));
			SerializeField(s, nameof(Path__9));
			SerializeField(s, nameof(Vector3__10));
			SerializeField(s, nameof(Vector2__11));
			SerializeField(s, nameof(Angle__12));
			SerializeField(s, nameof(bool__13));
		}
		public override uint? ClassCRC => 0xFFDA9322;
	}
}

