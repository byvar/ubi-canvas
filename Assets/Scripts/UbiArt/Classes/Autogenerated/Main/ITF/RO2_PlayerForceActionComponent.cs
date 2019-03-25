using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerForceActionComponent : ActorComponent {
		[Serialize("Action"                )] public PlayerForcedAction Action;
		[Serialize("enabledOnInit"         )] public bool enabledOnInit;
		[Serialize("OverallPriority"       )] public uint OverallPriority;
		[Serialize("priority"              )] public uint priority;
		[Serialize("Hold"                  )] public bool Hold;
		[Serialize("Sprint"                )] public bool Sprint;
		[Serialize("KeepDirection"         )] public bool KeepDirection;
		[Serialize("WaitDuration"          )] public float WaitDuration;
		[Serialize("WaitType"              )] public Enum_WaitType WaitType;
		[Serialize("eventToListen"         )] public Generic<Event> eventToListen;
		[Serialize("waitSpecificAngle"     )] public bool waitSpecificAngle;
		[Serialize("waitSpecificAngleRange")] public Vector2 waitSpecificAngleRange;
		[Serialize("checkEventOnlyInZone"  )] public bool checkEventOnlyInZone;
		[Serialize("actorUpdateInfo"       )] public RO2_PlayerForceActionComponent.ActorUpdateInfoStruct actorUpdateInfo;
		[Serialize("isEnabled"             )] public bool isEnabled;
		[Serialize("Action"                )] public PlayerForcedAction2 Action2;
		[Serialize("shadowActorGroupTest"  )] public bool shadowActorGroupTest;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Action2));
					SerializeField(s, nameof(enabledOnInit), boolAsByte: true);
					SerializeField(s, nameof(OverallPriority));
					SerializeField(s, nameof(priority));
					SerializeField(s, nameof(Hold), boolAsByte: true);
					SerializeField(s, nameof(Sprint), boolAsByte: true);
					SerializeField(s, nameof(KeepDirection), boolAsByte: true);
					SerializeField(s, nameof(WaitDuration));
					SerializeField(s, nameof(WaitType));
					SerializeField(s, nameof(eventToListen));
					SerializeField(s, nameof(waitSpecificAngle), boolAsByte: true);
					if (waitSpecificAngle) {
						SerializeField(s, nameof(waitSpecificAngleRange));
					}
					if (!eventToListen.IsNull) {
						SerializeField(s, nameof(checkEventOnlyInZone), boolAsByte: true);
					}
					SerializeField(s, nameof(actorUpdateInfo));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(shadowActorGroupTest), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Action));
					SerializeField(s, nameof(enabledOnInit));
					SerializeField(s, nameof(OverallPriority));
					SerializeField(s, nameof(priority));
					SerializeField(s, nameof(Hold));
					SerializeField(s, nameof(Sprint));
					SerializeField(s, nameof(KeepDirection));
					SerializeField(s, nameof(WaitDuration));
					SerializeField(s, nameof(WaitType));
					SerializeField(s, nameof(eventToListen));
					SerializeField(s, nameof(waitSpecificAngle));
					if (waitSpecificAngle) {
						SerializeField(s, nameof(waitSpecificAngleRange));
					}
					if (!eventToListen.IsNull) {
						SerializeField(s, nameof(checkEventOnlyInZone));
					}
					SerializeField(s, nameof(actorUpdateInfo));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.RL)]
		public partial class ActorUpdateInfoStruct : CSerializable {
			[Serialize("orientationUpdateType"              )] public Enum_orientationUpdateType orientationUpdateType;
			[Serialize("specificOrientation"                )] public Angle specificOrientation;
			[Serialize("axisRecenter_StopActionInCorridor"  )] public bool axisRecenter_StopActionInCorridor;
			[Serialize("axisRecenter_FollowDRCInteractActor")] public bool axisRecenter_FollowDRCInteractActor;
			[Serialize("retriggerOrderDelay"                )] public float retriggerOrderDelay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(orientationUpdateType));
				if (orientationUpdateType == Enum_orientationUpdateType.useOnlySpecific) {
					SerializeField(s, nameof(specificOrientation));
				}
				if (orientationUpdateType == Enum_orientationUpdateType.dynamicAxisRecenter) {
					if (Settings.s.game == Settings.Game.RL) {
						SerializeField(s, nameof(axisRecenter_StopActionInCorridor), boolAsByte: true);
					} else {
						SerializeField(s, nameof(axisRecenter_StopActionInCorridor));
					}
				}
				if (orientationUpdateType == Enum_orientationUpdateType.dynamicAxisRecenter ||
					orientationUpdateType == Enum_orientationUpdateType.dynamicHelicoCorridorRecenter) {
					if (Settings.s.game == Settings.Game.RL) {
						SerializeField(s, nameof(axisRecenter_FollowDRCInteractActor), boolAsByte: true);
					} else {
						SerializeField(s, nameof(axisRecenter_FollowDRCInteractActor));
					}
				}
				SerializeField(s, nameof(retriggerOrderDelay));
			}
			public enum Enum_orientationUpdateType {
				[Serialize("useEnter"                     )] useEnter = 0,
				[Serialize("alwaysKeepZoneInit"           )] alwaysKeepZoneInit = 1,
				[Serialize("dynamic"                      )] dynamic = 2,
				[Serialize("useOnlySpecific"              )] useOnlySpecific = 3,
				[Serialize("dynamicAxisRecenter"          )] dynamicAxisRecenter = 4,
				[Serialize("dynamicHelicoCorridorRecenter")] dynamicHelicoCorridorRecenter = 5,
			}
		}
		public enum PlayerForcedAction {
			[Serialize("PlayerForcedAction_None"  )] None = 0,
			[Serialize("PlayerForcedAction_Walk"  )] Walk = 1,
			[Serialize("PlayerForcedAction_Jump"  )] Jump = 2,
			[Serialize("PlayerForcedAction_Helico")] Helico = 3,
			[Serialize("PlayerForcedAction_Attack")] Attack = 4,
			[Serialize("PlayerForcedAction_Win"   )] Win = 5,
		}
		public enum Enum_WaitType {
			[Serialize("Classic"  )] Classic = 0,
			[Serialize("SlingShot")] SlingShot = 1,
			[Serialize("StuckUp"  )] StuckUp = 2,
		}
		public enum PlayerForcedAction2 {
			[Serialize("PlayerForcedAction_None")] None = 0,
			[Serialize("PlayerForcedAction_Walk")] Walk = 1,
			[Serialize("PlayerForcedAction_Jump")] Jump = 2,
			[Serialize("PlayerForcedAction_Helico")] Helico = 3,
			[Serialize("PlayerForcedAction_Attack")] Attack = 4,
		}
		public override uint? ClassCRC => 0x32CD8D9C;
	}
}

