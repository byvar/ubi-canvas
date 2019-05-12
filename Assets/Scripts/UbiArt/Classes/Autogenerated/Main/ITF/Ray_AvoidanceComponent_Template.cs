using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AvoidanceComponent_Template : ActorComponent_Template {
		[Serialize("enabled"          )] public int enabled;
		[Serialize("radius"           )] public float radius;
		[Serialize("minDelta"         )] public float minDelta;
		[Serialize("anticipationCoeff")] public float anticipationCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enabled));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(minDelta));
			SerializeField(s, nameof(anticipationCoeff));
		}
		public override uint? ClassCRC => 0x9C8C9872;
	}
}

