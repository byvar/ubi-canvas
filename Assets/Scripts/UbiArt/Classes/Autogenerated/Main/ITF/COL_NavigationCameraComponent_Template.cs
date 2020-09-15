using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NavigationCameraComponent_Template : CSerializable {
		[Serialize("flyingLookAtOffset")] public Vec2d flyingLookAtOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flyingLookAtOffset));
		}
		public override uint? ClassCRC => 0x8CEFB6B9;
	}
}

