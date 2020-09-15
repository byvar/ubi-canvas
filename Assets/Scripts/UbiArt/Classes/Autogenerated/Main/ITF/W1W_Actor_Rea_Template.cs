using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Template : ActorComponent_Template {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("float__1"   )] public float float__1;
		[Serialize("Vector2__2" )] public Vec2d Vector2__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(Vector2__2));
		}
		public override uint? ClassCRC => 0x6F0AFE93;
	}
}

