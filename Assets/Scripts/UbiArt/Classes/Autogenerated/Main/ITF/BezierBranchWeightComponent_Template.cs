using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierBranchWeightComponent_Template : BezierBranchComponent_Template {
		public Angle minAngle;
		public Angle maxAngle;
		public float bendingSpeed;
		public float weightInfluence;
		public float weightMinValue;
		public float weightMaxValue;
		public float forceInfluence;
		public float forceDuration;
		public float forceMinSpeed;
		public float forceMaxSpeed;
		public bool exclusiveForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			bendingSpeed = s.Serialize<float>(bendingSpeed, name: "bendingSpeed");
			weightInfluence = s.Serialize<float>(weightInfluence, name: "weightInfluence");
			weightMinValue = s.Serialize<float>(weightMinValue, name: "weightMinValue");
			weightMaxValue = s.Serialize<float>(weightMaxValue, name: "weightMaxValue");
			forceInfluence = s.Serialize<float>(forceInfluence, name: "forceInfluence");
			forceDuration = s.Serialize<float>(forceDuration, name: "forceDuration");
			forceMinSpeed = s.Serialize<float>(forceMinSpeed, name: "forceMinSpeed");
			forceMaxSpeed = s.Serialize<float>(forceMaxSpeed, name: "forceMaxSpeed");
			exclusiveForce = s.Serialize<bool>(exclusiveForce, name: "exclusiveForce");
		}
		public override uint? ClassCRC => 0x5F1739C7;
	}
}

