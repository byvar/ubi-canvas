using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Npc_Template : ActorComponent_Template {
		[Serialize("float__0")] public float float__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("float__2")] public float float__2;
		[Serialize("float__3")] public float float__3;
		[Serialize("float__4")] public float float__4;
		[Serialize("float__5")] public float float__5;
		[Serialize("float__6")] public float float__6;
		[Serialize("Path__7" )] public Path Path__7;
		[Serialize("int__8"  )] public int int__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(Path__7));
			SerializeField(s, nameof(int__8));
		}
		public override uint? ClassCRC => 0x4EB2F4D7;
	}
}

