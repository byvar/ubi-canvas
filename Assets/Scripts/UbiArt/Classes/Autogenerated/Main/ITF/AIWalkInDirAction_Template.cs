using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AIWalkInDirAction_Template : AIAction_Template {
		public float walkForce;
		public float walkForceRandomFactor;
		public float efficiencyMaxSpeed;
		public float efficiencyMaxSpeedRandomFactor;
		public Angle efficiencyMinGroundAngle;
		public Angle efficiencyMaxGroundAngle;
		public float efficiencyMinAngleMultiplier;
		public float efficiencyMaxAngleMultiplier;
		public float moveTargetMultiplierMin;
		public float moveTargetMultiplierMax;
		public float moveTargetBlendTime;
		public float walkAnimRate;
		public float minTime;
		public float maxTime;
		public bool walkLeftFlipsAnim;
		public bool useGroundAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walkForce = s.Serialize<float>(walkForce, name: "walkForce");
			walkForceRandomFactor = s.Serialize<float>(walkForceRandomFactor, name: "walkForceRandomFactor");
			efficiencyMaxSpeed = s.Serialize<float>(efficiencyMaxSpeed, name: "efficiencyMaxSpeed");
			efficiencyMaxSpeedRandomFactor = s.Serialize<float>(efficiencyMaxSpeedRandomFactor, name: "efficiencyMaxSpeedRandomFactor");
			efficiencyMinGroundAngle = s.SerializeObject<Angle>(efficiencyMinGroundAngle, name: "efficiencyMinGroundAngle");
			efficiencyMaxGroundAngle = s.SerializeObject<Angle>(efficiencyMaxGroundAngle, name: "efficiencyMaxGroundAngle");
			efficiencyMinAngleMultiplier = s.Serialize<float>(efficiencyMinAngleMultiplier, name: "efficiencyMinAngleMultiplier");
			efficiencyMaxAngleMultiplier = s.Serialize<float>(efficiencyMaxAngleMultiplier, name: "efficiencyMaxAngleMultiplier");
			moveTargetMultiplierMin = s.Serialize<float>(moveTargetMultiplierMin, name: "moveTargetMultiplierMin");
			moveTargetMultiplierMax = s.Serialize<float>(moveTargetMultiplierMax, name: "moveTargetMultiplierMax");
			moveTargetBlendTime = s.Serialize<float>(moveTargetBlendTime, name: "moveTargetBlendTime");
			walkAnimRate = s.Serialize<float>(walkAnimRate, name: "walkAnimRate");
			minTime = s.Serialize<float>(minTime, name: "minTime");
			maxTime = s.Serialize<float>(maxTime, name: "maxTime");
			walkLeftFlipsAnim = s.Serialize<bool>(walkLeftFlipsAnim, name: "walkLeftFlipsAnim");
			useGroundAngle = s.Serialize<bool>(useGroundAngle, name: "useGroundAngle");
		}
		public override uint? ClassCRC => 0xDEBBEFCF;
	}
}

