using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchWeightComponent_Template : BezierBranchComponent_Template {
		[Serialize("minAngle"       )] public Angle minAngle;
		[Serialize("maxAngle"       )] public Angle maxAngle;
		[Serialize("bendingSpeed"   )] public float bendingSpeed;
		[Serialize("weightInfluence")] public float weightInfluence;
		[Serialize("weightMinValue" )] public float weightMinValue;
		[Serialize("weightMaxValue" )] public float weightMaxValue;
		[Serialize("forceInfluence" )] public float forceInfluence;
		[Serialize("forceDuration"  )] public float forceDuration;
		[Serialize("forceMinSpeed"  )] public float forceMinSpeed;
		[Serialize("forceMaxSpeed"  )] public float forceMaxSpeed;
		[Serialize("exclusiveForce" )] public bool exclusiveForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(bendingSpeed));
			SerializeField(s, nameof(weightInfluence));
			SerializeField(s, nameof(weightMinValue));
			SerializeField(s, nameof(weightMaxValue));
			SerializeField(s, nameof(forceInfluence));
			SerializeField(s, nameof(forceDuration));
			SerializeField(s, nameof(forceMinSpeed));
			SerializeField(s, nameof(forceMaxSpeed));
			SerializeField(s, nameof(exclusiveForce));
		}
		public override uint? ClassCRC => 0x5F1739C7;
	}
}

