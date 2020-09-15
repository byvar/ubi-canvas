using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NavigationCameraComponent_Template : CSerializable {
		public Vec2d flyingLookAtOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flyingLookAtOffset = s.SerializeObject<Vec2d>(flyingLookAtOffset, name: "flyingLookAtOffset");
		}
		public override uint? ClassCRC => 0x8CEFB6B9;
	}
}

