using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroSpikyComponent_Template : RO2_RailComponent_Template {
		public float acceleration;
		public float drcAcceleration;
		public bool gyroMode;
		public bool drcMode;
		public float frictionMin;
		public float frictionMax;
		public Angle angleFrictionMax;
		public Angle angleFrictionMin;
		public float drcSwipeValidationSpeed;
		public Angle drcSwipeValidationAngle;
		public float drcStiffness;
		public float drcDamping;
		public float oneShotValidationTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			acceleration = s.Serialize<float>(acceleration, name: "acceleration");
			drcAcceleration = s.Serialize<float>(drcAcceleration, name: "drcAcceleration");
			gyroMode = s.Serialize<bool>(gyroMode, name: "gyroMode");
			drcMode = s.Serialize<bool>(drcMode, name: "drcMode");
			frictionMin = s.Serialize<float>(frictionMin, name: "frictionMin");
			frictionMax = s.Serialize<float>(frictionMax, name: "frictionMax");
			angleFrictionMax = s.SerializeObject<Angle>(angleFrictionMax, name: "angleFrictionMax");
			angleFrictionMin = s.SerializeObject<Angle>(angleFrictionMin, name: "angleFrictionMin");
			drcSwipeValidationSpeed = s.Serialize<float>(drcSwipeValidationSpeed, name: "drcSwipeValidationSpeed");
			drcSwipeValidationAngle = s.SerializeObject<Angle>(drcSwipeValidationAngle, name: "drcSwipeValidationAngle");
			drcStiffness = s.Serialize<float>(drcStiffness, name: "drcStiffness");
			drcDamping = s.Serialize<float>(drcDamping, name: "drcDamping");
			oneShotValidationTime = s.Serialize<float>(oneShotValidationTime, name: "oneShotValidationTime");
		}
		public override uint? ClassCRC => 0x3EC5A53C;
	}
}

