using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DarkCreatureSimulation : RO2_SoftCollisionSimulation {
		[Serialize("LightLifeTime"           )] public float LightLifeTime;
		[Serialize("RoamingMoveToTargetCoeff")] public float RoamingMoveToTargetCoeff;
		[Serialize("LightingRepulsionCoeff"  )] public float LightingRepulsionCoeff;
		[Serialize("ScaredSpeedCoeff"        )] public float ScaredSpeedCoeff;
		[Serialize("ChasingSpeedCoeff"       )] public float ChasingSpeedCoeff;
		[Serialize("IsBlind"                 )] public bool IsBlind;
		[Serialize("DetectionDistance"       )] public float DetectionDistance;
		[Serialize("AttackDistance"          )] public float AttackDistance;
		[Serialize("NoRespawnPlayerKill"     )] public bool NoRespawnPlayerKill;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(LightLifeTime));
				SerializeField(s, nameof(RoamingMoveToTargetCoeff));
				SerializeField(s, nameof(LightingRepulsionCoeff));
				SerializeField(s, nameof(ScaredSpeedCoeff));
				SerializeField(s, nameof(ChasingSpeedCoeff));
				SerializeField(s, nameof(IsBlind));
				SerializeField(s, nameof(DetectionDistance));
				SerializeField(s, nameof(AttackDistance));
				SerializeField(s, nameof(NoRespawnPlayerKill));
			}
		}
		public override uint? ClassCRC => 0x129523AC;
	}
}

