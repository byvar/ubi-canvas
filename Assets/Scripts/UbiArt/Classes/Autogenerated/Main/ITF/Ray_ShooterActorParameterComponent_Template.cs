using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterActorParameterComponent_Template : CSerializable {
		[Serialize("vacuumData"                                                  )] public Placeholder vacuumData;
		[Serialize("playerEjectBehavior"                                         )] public Placeholder playerEjectBehavior;
		[Serialize("playerStartVaccumBehavior"                                   )] public Placeholder playerStartVaccumBehavior;
		[Serialize("playerVacuumBehavior"                                        )] public Placeholder playerVacuumBehavior;
		[Serialize("playerVacuumEffectiveBehavior"                               )] public Placeholder playerVacuumEffectiveBehavior;
		[Serialize("enemyReVacuumedSwallowedBhvName"                             )] public StringID enemyReVacuumedSwallowedBhvName;
		[Serialize("vacuumFxNamesContainer"                                      )] public Placeholder vacuumFxNamesContainer;
		[Serialize("VacuumFxNames"                                               )] public Placeholder VacuumFxNames;
		[Serialize("vacuumedReward"                                              )] public Placeholder vacuumedReward;
		[Serialize("deathRewardSpawnPath"                                        )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"                                           )] public uint deathRewardNumber;
		[Serialize("stackData"                                                   )] public Placeholder stackData;
		[Serialize("Ray_ShooterActorParameter_StackData"                         )] public Placeholder Ray_ShooterActorParameter_StackData;
		[Serialize("onVacuumedStim"                                              )] public Placeholder onVacuumedStim;
		[Serialize("onEnemyReVacuumedStim"                                       )] public Placeholder onEnemyReVacuumedStim;
		[Serialize("Ray_VacuumData_Template__0"                                  )] public Ray_VacuumData_Template Ray_VacuumData_Template__0;
		[Serialize("Generic<TemplateAIBehavior>__1"                              )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__1;
		[Serialize("Generic<TemplateAIBehavior>__2"                              )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__2;
		[Serialize("Generic<TemplateAIBehavior>__3"                              )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__3;
		[Serialize("Generic<TemplateAIBehavior>__4"                              )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__4;
		[Serialize("StringID__5"                                                 )] public StringID StringID__5;
		[Serialize("Ray_ShooterActorParameterComponent_Template.VacuumFxNames__6")] public Ray_ShooterActorParameterComponent_Template.VacuumFxNames Ray_ShooterActorParameterComponent_Template_VacuumFxNames__6;
		[Serialize("Generic<Ray_EventSpawnReward>__7"                            )] public Generic<Ray_EventSpawnReward> Generic_Ray_EventSpawnReward__7;
		[Serialize("Path__8"                                                     )] public Path Path__8;
		[Serialize("uint__9"                                                     )] public uint uint__9;
		[Serialize("Ray_ShooterActorParameter_StackData__10"                     )] public Ray_ShooterActorParameter_StackData Ray_ShooterActorParameter_StackData__10;
		[Serialize("Generic<PunchStim>__11"                                      )] public Generic<PunchStim> Generic_PunchStim__11;
		[Serialize("Generic<PunchStim>__12"                                      )] public Generic<PunchStim> Generic_PunchStim__12;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else {
				SerializeField(s, nameof(Ray_VacuumData_Template__0));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__1));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__2));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__3));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__4));
				SerializeField(s, nameof(StringID__5));
				SerializeField(s, nameof(Ray_ShooterActorParameterComponent_Template_VacuumFxNames__6));
				SerializeField(s, nameof(Generic_Ray_EventSpawnReward__7));
				SerializeField(s, nameof(Path__8));
				SerializeField(s, nameof(uint__9));
				SerializeField(s, nameof(Ray_ShooterActorParameter_StackData__10));
				SerializeField(s, nameof(Generic_PunchStim__11));
				SerializeField(s, nameof(Generic_PunchStim__12));
			}
		}
		[Games(GameFlags.RFR)]
		public partial class VacuumFxNames : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			[Serialize("StringID__2")] public StringID StringID__2;
			[Serialize("StringID__3")] public StringID StringID__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
			}
		}
		public override uint? ClassCRC => 0x7940B3D2;
	}
}

