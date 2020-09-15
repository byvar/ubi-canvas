using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AvoidanceComponent_Template : ActorComponent_Template {
		public int enabled;
		public float radius;
		public float minDelta;
		public float anticipationCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enabled = s.Serialize<int>(enabled, name: "enabled");
			radius = s.Serialize<float>(radius, name: "radius");
			minDelta = s.Serialize<float>(minDelta, name: "minDelta");
			anticipationCoeff = s.Serialize<float>(anticipationCoeff, name: "anticipationCoeff");
		}
		public override uint? ClassCRC => 0x9C8C9872;
	}
}

