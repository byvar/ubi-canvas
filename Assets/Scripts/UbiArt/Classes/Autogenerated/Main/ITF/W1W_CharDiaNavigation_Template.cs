using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CharDiaNavigation_Template : ActorComponent_Template {
		[Serialize("Vector2__0")] public Vector2 Vector2__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector2__0));
		}
		public override uint? ClassCRC => 0x3557406E;
	}
}

