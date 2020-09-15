using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("defaultSpeed"  )] public Vec2d defaultSpeed;
		[Serialize("defaultZOffset")] public float defaultZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultSpeed));
			SerializeField(s, nameof(defaultZOffset));
		}
		public override uint? ClassCRC => 0x5ACC2440;
	}
}

