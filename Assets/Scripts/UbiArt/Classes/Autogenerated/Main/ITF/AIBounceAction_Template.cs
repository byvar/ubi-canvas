using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIBounceAction_Template : AIAction_Template {
		[Serialize("maxXSpeed"              )] public float maxXSpeed;
		[Serialize("bounceForce"            )] public float bounceForce;
		[Serialize("maxXSpeedThresholdForce")] public float maxXSpeedThresholdForce;
		[Serialize("minBounceAngle"         )] public Angle minBounceAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxXSpeed));
			SerializeField(s, nameof(bounceForce));
			SerializeField(s, nameof(maxXSpeedThresholdForce));
			SerializeField(s, nameof(minBounceAngle));
		}
		public override uint? ClassCRC => 0x63987C5A;
	}
}

