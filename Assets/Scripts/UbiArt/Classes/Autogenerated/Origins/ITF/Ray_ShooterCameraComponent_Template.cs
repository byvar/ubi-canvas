using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("defaultSpeed"  )] public Vector2 defaultSpeed;
		[Serialize("defaultZOffset")] public float defaultZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultSpeed));
			SerializeField(s, nameof(defaultZOffset));
		}
		public override uint? ClassCRC => 0xF51A4F6E;
	}
}

