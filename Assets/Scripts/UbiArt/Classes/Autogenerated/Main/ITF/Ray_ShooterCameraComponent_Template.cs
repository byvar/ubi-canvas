using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCameraComponent_Template : BaseCameraComponent_Template {
		public Vec2d defaultSpeed;
		public float defaultZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultSpeed = s.SerializeObject<Vec2d>(defaultSpeed, name: "defaultSpeed");
			defaultZOffset = s.Serialize<float>(defaultZOffset, name: "defaultZOffset");
		}
		public override uint? ClassCRC => 0xF51A4F6E;
	}
}

