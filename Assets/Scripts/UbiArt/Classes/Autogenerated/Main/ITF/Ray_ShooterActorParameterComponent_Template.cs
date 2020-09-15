using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterActorParameterComponent_Template : ActorComponent_Template {
		public Ray_VacuumData_Template vacuumData;
		public Generic<TemplateAIBehavior> playerEjectBehavior;
		public Generic<TemplateAIBehavior> playerStartVaccumBehavior;
		public Generic<TemplateAIBehavior> playerVacuumBehavior;
		public Generic<TemplateAIBehavior> playerVacuumEffectiveBehavior;
		public StringID enemyReVacuumedSwallowedBhvName;
		public Ray_ShooterActorParameterComponent_Template.VacuumFxNames vacuumFxNamesContainer;
		public Generic<Ray_EventSpawnReward> vacuumedReward;
		public Path deathRewardSpawnPath;
		public uint deathRewardNumber;
		public Ray_ShooterActorParameter_StackData stackData;
		public Generic<PunchStim> onVacuumedStim;
		public Generic<PunchStim> onEnemyReVacuumedStim;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			vacuumData = s.SerializeObject<Ray_VacuumData_Template>(vacuumData, name: "vacuumData");
			playerEjectBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerEjectBehavior, name: "playerEjectBehavior");
			playerStartVaccumBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerStartVaccumBehavior, name: "playerStartVaccumBehavior");
			playerVacuumBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerVacuumBehavior, name: "playerVacuumBehavior");
			playerVacuumEffectiveBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(playerVacuumEffectiveBehavior, name: "playerVacuumEffectiveBehavior");
			enemyReVacuumedSwallowedBhvName = s.SerializeObject<StringID>(enemyReVacuumedSwallowedBhvName, name: "enemyReVacuumedSwallowedBhvName");
			vacuumFxNamesContainer = s.SerializeObject<Ray_ShooterActorParameterComponent_Template.VacuumFxNames>(vacuumFxNamesContainer, name: "vacuumFxNamesContainer");
			vacuumedReward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(vacuumedReward, name: "vacuumedReward");
			deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
			deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
			stackData = s.SerializeObject<Ray_ShooterActorParameter_StackData>(stackData, name: "stackData");
			onVacuumedStim = s.SerializeObject<Generic<PunchStim>>(onVacuumedStim, name: "onVacuumedStim");
			onEnemyReVacuumedStim = s.SerializeObject<Generic<PunchStim>>(onEnemyReVacuumedStim, name: "onEnemyReVacuumedStim");
		}
		[Games(GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
		public partial class VacuumFxNames : CSerializable {
			public StringID fxNameVacuuming;
			public StringID fxNameVacuumingStop;
			public StringID fxNameDetached;
			public StringID fxNameEjected;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				fxNameVacuuming = s.SerializeObject<StringID>(fxNameVacuuming, name: "fxNameVacuuming");
				fxNameVacuumingStop = s.SerializeObject<StringID>(fxNameVacuumingStop, name: "fxNameVacuumingStop");
				fxNameDetached = s.SerializeObject<StringID>(fxNameDetached, name: "fxNameDetached");
				fxNameEjected = s.SerializeObject<StringID>(fxNameEjected, name: "fxNameEjected");
			}
		}
		public override uint? ClassCRC => 0x7940B3D2;
	}
}

