using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventAreaOfEffect : Event {
		[Serialize("float__0"    )] public float float__0;
		[Serialize("Enum_VH_0__1")] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("Vector2__2"  )] public Vector2 Vector2__2;
		[Serialize("Vector2__3"  )] public Vector2 Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(Enum_VH_0__1));
			SerializeField(s, nameof(Vector2__2));
			SerializeField(s, nameof(Vector2__3));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
		}
		public override uint? ClassCRC => 0xF6E63A46;
	}
}

