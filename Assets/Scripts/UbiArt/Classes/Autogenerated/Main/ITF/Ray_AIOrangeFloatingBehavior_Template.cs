using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIOrangeFloatingBehavior_Template : Ray_AIWaterFloatingBehavior_Template {
		[Serialize("orangeMinSpeed"        )] public float orangeMinSpeed;
		[Serialize("orangeMaxSpeed"        )] public float orangeMaxSpeed;
		[Serialize("landingSpeedXThreshold")] public float landingSpeedXThreshold;
		[Serialize("arrivalDistance"       )] public float arrivalDistance;
		[Serialize("moveThreshold"         )] public float moveThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(orangeMinSpeed));
			SerializeField(s, nameof(orangeMaxSpeed));
			SerializeField(s, nameof(landingSpeedXThreshold));
			SerializeField(s, nameof(arrivalDistance));
			SerializeField(s, nameof(moveThreshold));
		}
		public override uint? ClassCRC => 0x02C17387;
	}
}

