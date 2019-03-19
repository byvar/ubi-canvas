using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RotatingPlatformComponent_Template : ActorComponent_Template {
		[Serialize("rotationSpeed"          )] public float rotationSpeed;
		[Serialize("shakingAmplitude"       )] public float shakingAmplitude;
		[Serialize("feedbackStuckAmplitude" )] public float feedbackStuckAmplitude;
		[Serialize("centerDeadZoneHalfWidth")] public float centerDeadZoneHalfWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(shakingAmplitude));
			SerializeField(s, nameof(feedbackStuckAmplitude));
			SerializeField(s, nameof(centerDeadZoneHalfWidth));
		}
		public override uint? ClassCRC => 0x0A45FA22;
	}
}

