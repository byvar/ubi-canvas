using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIWaterFloatingBehavior_Template : Ray_AIWaterBaseBehavior_Template {
		public float minSpeed;
		public float maxSpeed;
		public float minForce;
		public float maxForce;
		public float speedScaleMin;
		public float speedScaleMax;
		public float landForceMultiplier;
		public float landXForceMultiplier;
		public Generic<Ray_AIWaterFloatAction_Template> _float;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minForce = s.Serialize<float>(minForce, name: "minForce");
			maxForce = s.Serialize<float>(maxForce, name: "maxForce");
			speedScaleMin = s.Serialize<float>(speedScaleMin, name: "speedScaleMin");
			speedScaleMax = s.Serialize<float>(speedScaleMax, name: "speedScaleMax");
			landForceMultiplier = s.Serialize<float>(landForceMultiplier, name: "landForceMultiplier");
			landXForceMultiplier = s.Serialize<float>(landXForceMultiplier, name: "landXForceMultiplier");
			_float = s.SerializeObject<Generic<Ray_AIWaterFloatAction_Template>>(_float, name: "float");
		}
		public override uint? ClassCRC => 0xF74EBFDD;
	}
}

