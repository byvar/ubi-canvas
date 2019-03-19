using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroSpikyComponent_Template : RO2_RailComponent_Template {
		[Serialize("acceleration"           )] public float acceleration;
		[Serialize("drcAcceleration"        )] public float drcAcceleration;
		[Serialize("gyroMode"               )] public bool gyroMode;
		[Serialize("drcMode"                )] public bool drcMode;
		[Serialize("frictionMin"            )] public float frictionMin;
		[Serialize("frictionMax"            )] public float frictionMax;
		[Serialize("angleFrictionMax"       )] public Angle angleFrictionMax;
		[Serialize("angleFrictionMin"       )] public Angle angleFrictionMin;
		[Serialize("drcSwipeValidationSpeed")] public float drcSwipeValidationSpeed;
		[Serialize("drcSwipeValidationAngle")] public Angle drcSwipeValidationAngle;
		[Serialize("drcStiffness"           )] public float drcStiffness;
		[Serialize("drcDamping"             )] public float drcDamping;
		[Serialize("oneShotValidationTime"  )] public float oneShotValidationTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(acceleration));
			SerializeField(s, nameof(drcAcceleration));
			SerializeField(s, nameof(gyroMode));
			SerializeField(s, nameof(drcMode));
			SerializeField(s, nameof(frictionMin));
			SerializeField(s, nameof(frictionMax));
			SerializeField(s, nameof(angleFrictionMax));
			SerializeField(s, nameof(angleFrictionMin));
			SerializeField(s, nameof(drcSwipeValidationSpeed));
			SerializeField(s, nameof(drcSwipeValidationAngle));
			SerializeField(s, nameof(drcStiffness));
			SerializeField(s, nameof(drcDamping));
			SerializeField(s, nameof(oneShotValidationTime));
		}
		public override uint? ClassCRC => 0x3EC5A53C;
	}
}

