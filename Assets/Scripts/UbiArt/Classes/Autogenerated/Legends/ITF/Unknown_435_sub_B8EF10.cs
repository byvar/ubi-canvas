using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_435_sub_B8EF10 : CSerializable {
		[Serialize("vacuumData"                     )] public Placeholder vacuumData;
		[Serialize("playerEjectBehavior"            )] public Placeholder playerEjectBehavior;
		[Serialize("playerStartVaccumBehavior"      )] public Placeholder playerStartVaccumBehavior;
		[Serialize("playerVacuumBehavior"           )] public Placeholder playerVacuumBehavior;
		[Serialize("playerVacuumEffectiveBehavior"  )] public Placeholder playerVacuumEffectiveBehavior;
		[Serialize("enemyReVacuumedSwallowedBhvName")] public StringID enemyReVacuumedSwallowedBhvName;
		[Serialize("playerStartVacuumFact"          )] public StringID playerStartVacuumFact;
		[Serialize("playerVacuumEffectiveFact"      )] public StringID playerVacuumEffectiveFact;
		[Serialize("playerEjectFact"                )] public StringID playerEjectFact;
		[Serialize("vacuumFxNamesContainer"         )] public Placeholder vacuumFxNamesContainer;
		[Serialize("vacuumedReward"                 )] public Placeholder vacuumedReward;
		[Serialize("deathRewardSpawnPath"           )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"              )] public uint deathRewardNumber;
		[Serialize("stackData"                      )] public Placeholder stackData;
		[Serialize("onVacuumedStim"                 )] public Placeholder onVacuumedStim;
		[Serialize("onEnemyReVacuumedStim"          )] public Placeholder onEnemyReVacuumedStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(vacuumData));
			SerializeField(s, nameof(playerEjectBehavior));
			SerializeField(s, nameof(playerStartVaccumBehavior));
			SerializeField(s, nameof(playerVacuumBehavior));
			SerializeField(s, nameof(playerVacuumEffectiveBehavior));
			SerializeField(s, nameof(enemyReVacuumedSwallowedBhvName));
			SerializeField(s, nameof(playerStartVacuumFact));
			SerializeField(s, nameof(playerVacuumEffectiveFact));
			SerializeField(s, nameof(playerEjectFact));
			SerializeField(s, nameof(vacuumFxNamesContainer));
			SerializeField(s, nameof(vacuumedReward));
			SerializeField(s, nameof(deathRewardSpawnPath));
			SerializeField(s, nameof(deathRewardNumber));
			SerializeField(s, nameof(stackData));
			SerializeField(s, nameof(onVacuumedStim));
			SerializeField(s, nameof(onEnemyReVacuumedStim));
		}
		public override uint? ClassCRC => 0xA97988AE;
	}
}

