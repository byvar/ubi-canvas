using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterActorParameterComponent_Template : ActorComponent_Template {
		[Serialize("vacuumData"                     )] public Ray_VacuumData_Template vacuumData;
		[Serialize("playerEjectBehavior"            )] public Generic<TemplateAIBehavior> playerEjectBehavior;
		[Serialize("playerStartVaccumBehavior"      )] public Generic<TemplateAIBehavior> playerStartVaccumBehavior;
		[Serialize("playerVacuumBehavior"           )] public Generic<TemplateAIBehavior> playerVacuumBehavior;
		[Serialize("playerVacuumEffectiveBehavior"  )] public Generic<TemplateAIBehavior> playerVacuumEffectiveBehavior;
		[Serialize("enemyReVacuumedSwallowedBhvName")] public StringID enemyReVacuumedSwallowedBhvName;
		[Serialize("playerStartVacuumFact"          )] public StringID playerStartVacuumFact;
		[Serialize("playerVacuumEffectiveFact"      )] public StringID playerVacuumEffectiveFact;
		[Serialize("playerEjectFact"                )] public StringID playerEjectFact;
		[Serialize("vacuumFxNamesContainer"         )] public Ray_ShooterActorParameterComponent_Template.VacuumFxNames vacuumFxNamesContainer;
		[Serialize("vacuumedReward"                 )] public Generic<Event> vacuumedReward;
		[Serialize("deathRewardSpawnPath"           )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"              )] public uint deathRewardNumber;
		[Serialize("stackData"                      )] public Ray_ShooterActorParameter_StackData stackData;
		[Serialize("onVacuumedStim"                 )] public Generic<Event> onVacuumedStim;
		[Serialize("onEnemyReVacuumedStim"          )] public Generic<Event> onEnemyReVacuumedStim;
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

