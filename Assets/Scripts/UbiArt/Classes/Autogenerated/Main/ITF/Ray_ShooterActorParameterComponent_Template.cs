using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterActorParameterComponent_Template : ActorComponent_Template {
		[Serialize("vacuumData"                     )] public Ray_VacuumData_Template vacuumData;
		[Serialize("playerEjectBehavior"            )] public Generic<TemplateAIBehavior> playerEjectBehavior;
		[Serialize("playerStartVaccumBehavior"      )] public Generic<TemplateAIBehavior> playerStartVaccumBehavior;
		[Serialize("playerVacuumBehavior"           )] public Generic<TemplateAIBehavior> playerVacuumBehavior;
		[Serialize("playerVacuumEffectiveBehavior"  )] public Generic<TemplateAIBehavior> playerVacuumEffectiveBehavior;
		[Serialize("enemyReVacuumedSwallowedBhvName")] public StringID enemyReVacuumedSwallowedBhvName;
		[Serialize("vacuumFxNamesContainer"         )] public Ray_ShooterActorParameterComponent_Template.VacuumFxNames vacuumFxNamesContainer;
		[Serialize("vacuumedReward"                 )] public Generic<Ray_EventSpawnReward> vacuumedReward;
		[Serialize("deathRewardSpawnPath"           )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"              )] public uint deathRewardNumber;
		[Serialize("stackData"                      )] public Ray_ShooterActorParameter_StackData stackData;
		[Serialize("onVacuumedStim"                 )] public Generic<PunchStim> onVacuumedStim;
		[Serialize("onEnemyReVacuumedStim"          )] public Generic<PunchStim> onEnemyReVacuumedStim;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(vacuumData));
			SerializeField(s, nameof(playerEjectBehavior));
			SerializeField(s, nameof(playerStartVaccumBehavior));
			SerializeField(s, nameof(playerVacuumBehavior));
			SerializeField(s, nameof(playerVacuumEffectiveBehavior));
			SerializeField(s, nameof(enemyReVacuumedSwallowedBhvName));
			SerializeField(s, nameof(vacuumFxNamesContainer));
			SerializeField(s, nameof(vacuumedReward));
			SerializeField(s, nameof(deathRewardSpawnPath));
			SerializeField(s, nameof(deathRewardNumber));
			SerializeField(s, nameof(stackData));
			SerializeField(s, nameof(onVacuumedStim));
			SerializeField(s, nameof(onEnemyReVacuumedStim));
		}
		[Games(GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
		public partial class VacuumFxNames : CSerializable {
			[Serialize("fxNameVacuuming"    )] public StringID fxNameVacuuming;
			[Serialize("fxNameVacuumingStop")] public StringID fxNameVacuumingStop;
			[Serialize("fxNameDetached"     )] public StringID fxNameDetached;
			[Serialize("fxNameEjected"      )] public StringID fxNameEjected;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(fxNameVacuuming));
				SerializeField(s, nameof(fxNameVacuumingStop));
				SerializeField(s, nameof(fxNameDetached));
				SerializeField(s, nameof(fxNameEjected));
			}
		}
		public override uint? ClassCRC => 0x7940B3D2;
	}
}

