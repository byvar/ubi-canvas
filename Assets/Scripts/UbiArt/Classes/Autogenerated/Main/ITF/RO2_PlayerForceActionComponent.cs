using UnityEngine;

namespace UbiArt.ITF {
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
		[Serialize("Action"                )] public Enum_Action Action;
		[Serialize("shadowActorGroupTest"  )] public bool shadowActorGroupTest;
		[Serialize("shadowActorGroupTest"  )] public Placeholder shadowActorGroupTest;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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
					SerializeField(s, nameof(waitSpecificAngleRange));
					SerializeField(s, nameof(checkEventOnlyInZone));
					SerializeField(s, nameof(actorUpdateInfo));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(shadowActorGroupTest));
				}
				SerializeField(s, nameof(shadowActorGroupTest));
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
					SerializeField(s, nameof(waitSpecificAngleRange));
					SerializeField(s, nameof(checkEventOnlyInZone));
					SerializeField(s, nameof(actorUpdateInfo));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
			}
		}
		public partial class ActorUpdateInfoStruct : CSerializable {
			[Serialize("orientationUpdateType"              )] public Enum_orientationUpdateType orientationUpdateType;
			[Serialize("specificOrientation"                )] public Angle specificOrientation;
			[Serialize("axisRecenter_StopActionInCorridor"  )] public bool axisRecenter_StopActionInCorridor;
			[Serialize("axisRecenter_FollowDRCInteractActor")] public bool axisRecenter_FollowDRCInteractActor;
			[Serialize("retriggerOrderDelay"                )] public float retriggerOrderDelay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(orientationUpdateType));
				SerializeField(s, nameof(specificOrientation));
				SerializeField(s, nameof(axisRecenter_StopActionInCorridor));
				SerializeField(s, nameof(axisRecenter_FollowDRCInteractActor));
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
		public enum Enum_Action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_WaitType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x32CD8D9C;
	}
}

