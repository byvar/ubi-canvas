using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterActorParameterComponent_Template : CSerializable {
		[Serialize("vacuumData"                         )] public Placeholder vacuumData;
		[Serialize("playerEjectBehavior"                )] public Placeholder playerEjectBehavior;
		[Serialize("playerStartVaccumBehavior"          )] public Placeholder playerStartVaccumBehavior;
		[Serialize("playerVacuumBehavior"               )] public Placeholder playerVacuumBehavior;
		[Serialize("playerVacuumEffectiveBehavior"      )] public Placeholder playerVacuumEffectiveBehavior;
		[Serialize("enemyReVacuumedSwallowedBhvName"    )] public StringID enemyReVacuumedSwallowedBhvName;
		[Serialize("vacuumFxNamesContainer"             )] public Placeholder vacuumFxNamesContainer;
		[Serialize("VacuumFxNames"                      )] public Placeholder VacuumFxNames;
		[Serialize("vacuumedReward"                     )] public Placeholder vacuumedReward;
		[Serialize("deathRewardSpawnPath"               )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"                  )] public uint deathRewardNumber;
		[Serialize("stackData"                          )] public Placeholder stackData;
		[Serialize("Ray_ShooterActorParameter_StackData")] public Placeholder Ray_ShooterActorParameter_StackData;
		[Serialize("onVacuumedStim"                     )] public Placeholder onVacuumedStim;
		[Serialize("onEnemyReVacuumedStim"              )] public Placeholder onEnemyReVacuumedStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(vacuumData));
			SerializeField(s, nameof(playerEjectBehavior));
			SerializeField(s, nameof(playerStartVaccumBehavior));
			SerializeField(s, nameof(playerVacuumBehavior));
			SerializeField(s, nameof(playerVacuumEffectiveBehavior));
			SerializeField(s, nameof(enemyReVacuumedSwallowedBhvName));
			SerializeField(s, nameof(vacuumFxNamesContainer));
			SerializeField(s, nameof(VacuumFxNames));
			SerializeField(s, nameof(vacuumedReward));
			SerializeField(s, nameof(deathRewardSpawnPath));
			SerializeField(s, nameof(deathRewardNumber));
			SerializeField(s, nameof(stackData));
			SerializeField(s, nameof(Ray_ShooterActorParameter_StackData));
			SerializeField(s, nameof(onVacuumedStim));
			SerializeField(s, nameof(onEnemyReVacuumedStim));
		}
		public override uint? ClassCRC => 0x7940B3D2;
	}
}

