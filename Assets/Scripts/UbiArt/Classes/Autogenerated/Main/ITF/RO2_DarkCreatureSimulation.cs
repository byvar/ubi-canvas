using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureSimulation : RO2_SoftCollisionSimulation {
		public float LightLifeTime;
		public float RoamingMoveToTargetCoeff;
		public float LightingRepulsionCoeff;
		public float ScaredSpeedCoeff;
		public float ChasingSpeedCoeff;
		public bool IsBlind;
		public float DetectionDistance;
		public float AttackDistance;
		public bool NoRespawnPlayerKill;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				LightLifeTime = s.Serialize<float>(LightLifeTime, name: "LightLifeTime");
				RoamingMoveToTargetCoeff = s.Serialize<float>(RoamingMoveToTargetCoeff, name: "RoamingMoveToTargetCoeff");
				LightingRepulsionCoeff = s.Serialize<float>(LightingRepulsionCoeff, name: "LightingRepulsionCoeff");
				ScaredSpeedCoeff = s.Serialize<float>(ScaredSpeedCoeff, name: "ScaredSpeedCoeff");
				ChasingSpeedCoeff = s.Serialize<float>(ChasingSpeedCoeff, name: "ChasingSpeedCoeff");
				IsBlind = s.Serialize<bool>(IsBlind, name: "IsBlind");
				DetectionDistance = s.Serialize<float>(DetectionDistance, name: "DetectionDistance");
				AttackDistance = s.Serialize<float>(AttackDistance, name: "AttackDistance");
				NoRespawnPlayerKill = s.Serialize<bool>(NoRespawnPlayerKill, name: "NoRespawnPlayerKill");
			}
		}
		public override uint? ClassCRC => 0x129523AC;
	}
}

