using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterActorParameterComponent_Template : ActorComponent_Template {
		public Ray_VacuumData_Template vacuumData;
		public Generic<TemplateAIBehavior> playerEjectBehavior;
		public Generic<TemplateAIBehavior> playerStartVaccumBehavior;
		public Generic<TemplateAIBehavior> playerVacuumBehavior;
		public Generic<TemplateAIBehavior> playerVacuumEffectiveBehavior;
		public StringID enemyReVacuumedSwallowedBhvName;
		public StringID playerStartVacuumFact;
		public StringID playerVacuumEffectiveFact;
		public StringID playerEjectFact;
		public Ray_ShooterActorParameterComponent_Template.VacuumFxNames vacuumFxNamesContainer;
		public Generic<Event> vacuumedReward;
		public Path deathRewardSpawnPath;
		public uint deathRewardNumber;
		public Ray_ShooterActorParameter_StackData stackData;
		public Generic<Event> onVacuumedStim;
		public Generic<Event> onEnemyReVacuumedStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			vacuumData = s.SerializeObject<Ray_VacuumData_Template>(vacuumData, name: "vacuumData");
			playerEjectBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerEjectBehavior, name: "playerEjectBehavior");
			playerStartVaccumBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerStartVaccumBehavior, name: "playerStartVaccumBehavior");
			playerVacuumBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerVacuumBehavior, name: "playerVacuumBehavior");
			playerVacuumEffectiveBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerVacuumEffectiveBehavior, name: "playerVacuumEffectiveBehavior");
			enemyReVacuumedSwallowedBhvName = s.SerializeObject<StringID>(enemyReVacuumedSwallowedBhvName, name: "enemyReVacuumedSwallowedBhvName");
			playerStartVacuumFact = s.SerializeObject<StringID>(playerStartVacuumFact, name: "playerStartVacuumFact");
			playerVacuumEffectiveFact = s.SerializeObject<StringID>(playerVacuumEffectiveFact, name: "playerVacuumEffectiveFact");
			playerEjectFact = s.SerializeObject<StringID>(playerEjectFact, name: "playerEjectFact");
			vacuumFxNamesContainer = s.SerializeObject<Ray_ShooterActorParameterComponent_Template.VacuumFxNames>(vacuumFxNamesContainer, name: "vacuumFxNamesContainer");
			vacuumedReward = s.SerializeObject<Generic<Event>>(vacuumedReward, name: "vacuumedReward");
			deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
			deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
			stackData = s.SerializeObject<Ray_ShooterActorParameter_StackData>(stackData, name: "stackData");
			onVacuumedStim = s.SerializeObject<Generic<Event>>(onVacuumedStim, name: "onVacuumedStim");
			onEnemyReVacuumedStim = s.SerializeObject<Generic<Event>>(onEnemyReVacuumedStim, name: "onEnemyReVacuumedStim");
		}
		public override uint? ClassCRC => 0xA97988AE;
	}
}

