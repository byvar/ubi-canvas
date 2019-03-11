using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIWalkInDirAction_Template : AIAction_Template {
		[Serialize("walkForce"                     )] public float walkForce;
		[Serialize("walkForceRandomFactor"         )] public float walkForceRandomFactor;
		[Serialize("efficiencyMaxSpeed"            )] public float efficiencyMaxSpeed;
		[Serialize("efficiencyMaxSpeedRandomFactor")] public float efficiencyMaxSpeedRandomFactor;
		[Serialize("efficiencyMinGroundAngle"      )] public Angle efficiencyMinGroundAngle;
		[Serialize("efficiencyMaxGroundAngle"      )] public Angle efficiencyMaxGroundAngle;
		[Serialize("efficiencyMinAngleMultiplier"  )] public float efficiencyMinAngleMultiplier;
		[Serialize("efficiencyMaxAngleMultiplier"  )] public float efficiencyMaxAngleMultiplier;
		[Serialize("moveTargetMultiplierMin"       )] public float moveTargetMultiplierMin;
		[Serialize("moveTargetMultiplierMax"       )] public float moveTargetMultiplierMax;
		[Serialize("moveTargetBlendTime"           )] public float moveTargetBlendTime;
		[Serialize("walkAnimRate"                  )] public float walkAnimRate;
		[Serialize("minTime"                       )] public float minTime;
		[Serialize("maxTime"                       )] public float maxTime;
		[Serialize("walkLeftFlipsAnim"             )] public bool walkLeftFlipsAnim;
		[Serialize("useGroundAngle"                )] public bool useGroundAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walkForce));
			SerializeField(s, nameof(walkForceRandomFactor));
			SerializeField(s, nameof(efficiencyMaxSpeed));
			SerializeField(s, nameof(efficiencyMaxSpeedRandomFactor));
			SerializeField(s, nameof(efficiencyMinGroundAngle));
			SerializeField(s, nameof(efficiencyMaxGroundAngle));
			SerializeField(s, nameof(efficiencyMinAngleMultiplier));
			SerializeField(s, nameof(efficiencyMaxAngleMultiplier));
			SerializeField(s, nameof(moveTargetMultiplierMin));
			SerializeField(s, nameof(moveTargetMultiplierMax));
			SerializeField(s, nameof(moveTargetBlendTime));
			SerializeField(s, nameof(walkAnimRate));
			SerializeField(s, nameof(minTime));
			SerializeField(s, nameof(maxTime));
			SerializeField(s, nameof(walkLeftFlipsAnim));
			SerializeField(s, nameof(useGroundAngle));
		}
		public override uint? ClassCRC => 0xDEBBEFCF;
	}
}

