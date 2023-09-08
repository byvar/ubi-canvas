namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlayerForceActionComponent : ActorComponent {
		public PlayerForcedAction Action;
		public bool enabledOnInit;
		public uint OverallPriority;
		public uint priority;
		public bool Hold;
		public bool Sprint;
		public bool KeepDirection;
		public float WaitDuration;
		public Enum_WaitType WaitType;
		public Generic<Event> eventToListen;
		public bool waitSpecificAngle;
		public Vec2d waitSpecificAngleRange;
		public bool checkEventOnlyInZone;
		public RO2_PlayerForceActionComponent.ActorUpdateInfoStruct actorUpdateInfo;
		public bool isEnabled;
		public PlayerForcedAction2 Action2;
		public bool shadowActorGroupTest;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					Action2 = s.Serialize<PlayerForcedAction2>(Action2, name: "Action");
					enabledOnInit = s.Serialize<bool>(enabledOnInit, name: "enabledOnInit", options: CSerializerObject.Options.BoolAsByte);
					OverallPriority = s.Serialize<uint>(OverallPriority, name: "OverallPriority");
					priority = s.Serialize<uint>(priority, name: "priority");
					Hold = s.Serialize<bool>(Hold, name: "Hold", options: CSerializerObject.Options.BoolAsByte);
					Sprint = s.Serialize<bool>(Sprint, name: "Sprint", options: CSerializerObject.Options.BoolAsByte);
					KeepDirection = s.Serialize<bool>(KeepDirection, name: "KeepDirection", options: CSerializerObject.Options.BoolAsByte);
					WaitDuration = s.Serialize<float>(WaitDuration, name: "WaitDuration");
					WaitType = s.Serialize<Enum_WaitType>(WaitType, name: "WaitType");
					eventToListen = s.SerializeObject<Generic<Event>>(eventToListen, name: "eventToListen");
					waitSpecificAngle = s.Serialize<bool>(waitSpecificAngle, name: "waitSpecificAngle", options: CSerializerObject.Options.BoolAsByte);
					if (waitSpecificAngle) {
						waitSpecificAngleRange = s.SerializeObject<Vec2d>(waitSpecificAngleRange, name: "waitSpecificAngleRange");
					}
					if (!eventToListen.IsNull) {
						checkEventOnlyInZone = s.Serialize<bool>(checkEventOnlyInZone, name: "checkEventOnlyInZone", options: CSerializerObject.Options.BoolAsByte);
					}
					actorUpdateInfo = s.SerializeObject<RO2_PlayerForceActionComponent.ActorUpdateInfoStruct>(actorUpdateInfo, name: "actorUpdateInfo");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					shadowActorGroupTest = s.Serialize<bool>(shadowActorGroupTest, name: "shadowActorGroupTest", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					Action = s.Serialize<PlayerForcedAction>(Action, name: "Action");
					enabledOnInit = s.Serialize<bool>(enabledOnInit, name: "enabledOnInit");
					OverallPriority = s.Serialize<uint>(OverallPriority, name: "OverallPriority");
					priority = s.Serialize<uint>(priority, name: "priority");
					Hold = s.Serialize<bool>(Hold, name: "Hold");
					Sprint = s.Serialize<bool>(Sprint, name: "Sprint");
					KeepDirection = s.Serialize<bool>(KeepDirection, name: "KeepDirection");
					WaitDuration = s.Serialize<float>(WaitDuration, name: "WaitDuration");
					WaitType = s.Serialize<Enum_WaitType>(WaitType, name: "WaitType");
					eventToListen = s.SerializeObject<Generic<Event>>(eventToListen, name: "eventToListen");
					waitSpecificAngle = s.Serialize<bool>(waitSpecificAngle, name: "waitSpecificAngle");
					if (waitSpecificAngle) {
						waitSpecificAngleRange = s.SerializeObject<Vec2d>(waitSpecificAngleRange, name: "waitSpecificAngleRange");
					}
					if (!eventToListen.IsNull) {
						checkEventOnlyInZone = s.Serialize<bool>(checkEventOnlyInZone, name: "checkEventOnlyInZone");
					}
					actorUpdateInfo = s.SerializeObject<RO2_PlayerForceActionComponent.ActorUpdateInfoStruct>(actorUpdateInfo, name: "actorUpdateInfo");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled");
				}
			}
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class ActorUpdateInfoStruct : CSerializable {
			public Enum_orientationUpdateType orientationUpdateType;
			public Angle specificOrientation;
			public bool axisRecenter_StopActionInCorridor;
			public bool axisRecenter_FollowDRCInteractActor;
			public float retriggerOrderDelay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				orientationUpdateType = s.Serialize<Enum_orientationUpdateType>(orientationUpdateType, name: "orientationUpdateType");
				if (orientationUpdateType == Enum_orientationUpdateType.useOnlySpecific) {
					specificOrientation = s.SerializeObject<Angle>(specificOrientation, name: "specificOrientation");
				}
				if (orientationUpdateType == Enum_orientationUpdateType.dynamicAxisRecenter) {
					if (s.Settings.Game == Game.RL) {
						axisRecenter_StopActionInCorridor = s.Serialize<bool>(axisRecenter_StopActionInCorridor, name: "axisRecenter_StopActionInCorridor", options: CSerializerObject.Options.BoolAsByte);
					} else {
						axisRecenter_StopActionInCorridor = s.Serialize<bool>(axisRecenter_StopActionInCorridor, name: "axisRecenter_StopActionInCorridor");
					}
				}
				if (orientationUpdateType == Enum_orientationUpdateType.dynamicAxisRecenter ||
					orientationUpdateType == Enum_orientationUpdateType.dynamicHelicoCorridorRecenter) {
					if (s.Settings.Game == Game.RL) {
						axisRecenter_FollowDRCInteractActor = s.Serialize<bool>(axisRecenter_FollowDRCInteractActor, name: "axisRecenter_FollowDRCInteractActor", options: CSerializerObject.Options.BoolAsByte);
					} else {
						axisRecenter_FollowDRCInteractActor = s.Serialize<bool>(axisRecenter_FollowDRCInteractActor, name: "axisRecenter_FollowDRCInteractActor");
					}
				}
				retriggerOrderDelay = s.Serialize<float>(retriggerOrderDelay, name: "retriggerOrderDelay");
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

