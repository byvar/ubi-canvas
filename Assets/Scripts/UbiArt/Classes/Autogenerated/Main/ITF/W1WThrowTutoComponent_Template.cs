using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1WThrowTutoComponent_Template : ActorComponent_Template {
		[Serialize("Vector2__0")] public Vector2 Vector2__0;
		[Serialize("float__1"  )] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector2__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x3B2BB9CF;
	}
}

