using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIWaterFloatingBehavior_Template : Ray_AIWaterBaseBehavior_Template {
		[Serialize("minSpeed"            )] public float minSpeed;
		[Serialize("maxSpeed"            )] public float maxSpeed;
		[Serialize("minForce"            )] public float minForce;
		[Serialize("maxForce"            )] public float maxForce;
		[Serialize("speedScaleMin"       )] public float speedScaleMin;
		[Serialize("speedScaleMax"       )] public float speedScaleMax;
		[Serialize("landForceMultiplier" )] public float landForceMultiplier;
		[Serialize("landXForceMultiplier")] public float landXForceMultiplier;
		[Serialize("float"               )] public Generic<Ray_AIWaterFloatAction_Template> _float;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(minForce));
			SerializeField(s, nameof(maxForce));
			SerializeField(s, nameof(speedScaleMin));
			SerializeField(s, nameof(speedScaleMax));
			SerializeField(s, nameof(landForceMultiplier));
			SerializeField(s, nameof(landXForceMultiplier));
			SerializeField(s, nameof(_float));
		}
		public override uint? ClassCRC => 0xF74EBFDD;
	}
}

