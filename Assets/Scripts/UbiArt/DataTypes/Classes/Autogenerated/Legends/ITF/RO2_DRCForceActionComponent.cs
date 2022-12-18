namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCForceActionComponent : ActorComponent {
		public Enum_forcedAction forcedAction;
		public bool followPlayer;
		public bool followPlayerUseCamDir;
		public bool autoAction;
		public bool useToTargetTravel;
		public RO2_TravelData toTargetTravel;
		public GyroData gyroData;
		public bool holdToggleMode;
		public bool holdDuringToTargetTravel;
		public bool canBackward;
		public bool canBackwardAnytime;
		public RO2_TravelData actionTravel;
		public ActivationData activationData;
		public int backward;
		public int enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				forcedAction = s.Serialize<Enum_forcedAction>(forcedAction, name: "forcedAction");
				if (forcedAction == Enum_forcedAction.NoTouch) {
					followPlayer = s.Serialize<bool>(followPlayer, name: "followPlayer", options: CSerializerObject.Options.BoolAsByte);
					if (followPlayer) {
						followPlayerUseCamDir = s.Serialize<bool>(followPlayerUseCamDir, name: "followPlayerUseCamDir", options: CSerializerObject.Options.BoolAsByte);
					}
				} else {
					autoAction = s.Serialize<bool>(autoAction, name: "autoAction", options: CSerializerObject.Options.BoolAsByte);
					useToTargetTravel = s.Serialize<bool>(useToTargetTravel, name: "useToTargetTravel", options: CSerializerObject.Options.BoolAsByte);
					if (useToTargetTravel) {
						toTargetTravel = s.SerializeObject<RO2_TravelData>(toTargetTravel, name: "toTargetTravel");
					}
					if (forcedAction == Enum_forcedAction.Gyro) {
						gyroData = s.SerializeObject<GyroData>(gyroData, name: "gyroData");
					} else if (forcedAction == Enum_forcedAction.TouchHold) {
						holdToggleMode = s.Serialize<bool>(holdToggleMode, name: "holdToggleMode", options: CSerializerObject.Options.BoolAsByte);
						if (useToTargetTravel) {
							holdDuringToTargetTravel = s.Serialize<bool>(holdDuringToTargetTravel, name: "holdDuringToTargetTravel", options: CSerializerObject.Options.BoolAsByte);
						}
					}
				}
				if (forcedAction != Enum_forcedAction.Gyro) {
					canBackward = s.Serialize<bool>(canBackward, name: "canBackward", options: CSerializerObject.Options.BoolAsByte);
					if (canBackward) {
						canBackwardAnytime = s.Serialize<bool>(canBackwardAnytime, name: "canBackwardAnytime", options: CSerializerObject.Options.BoolAsByte);
					}
					actionTravel = s.SerializeObject<RO2_TravelData>(actionTravel, name: "actionTravel");
				}
				activationData = s.SerializeObject<ActivationData>(activationData, name: "activationData");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				backward = s.Serialize<int>(backward, name: "backward");
				enabled = s.Serialize<int>(enabled, name: "enabled");
			}
		}
		public enum Enum_forcedAction {
			[Serialize("GenericTouch")] GenericTouch = 0,
			[Serialize("NoTouch"     )] NoTouch = 1,
			[Serialize("ZoneInteract")] ZoneInteract = 2,
			[Serialize("TouchHold"   )] TouchHold = 3,
			[Serialize("Gyro"        )] Gyro = 4,
			[Serialize("TouchOnInput")] TouchOnInput = 5,
		}
		public override uint? ClassCRC => 0xA38389F8;

		[Games(GameFlags.RL)]
		public partial class GyroData : CSerializable {
			public Angle speed;
			public Angle accel;
			public Angle decel;
			public bool invertRotation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				speed = s.SerializeObject<Angle>(speed, name: "speed");
				accel = s.SerializeObject<Angle>(accel, name: "accel");
				decel = s.SerializeObject<Angle>(decel, name: "decel");
				invertRotation = s.Serialize<bool>(invertRotation, name: "invertRotation", options: CSerializerObject.Options.BoolAsByte);
			}
		}

		[Games(GameFlags.RL)]
		public partial class ActivationData : CSerializable {
			public Enum_activationMode activationMode;
			public bool stopOnZoneExit;
			public bool canRestartAction;
			public bool cutPreviousAction;
			public uint priority;
			public bool saveBackward;
			public bool saveBackwardOnActionExit;
			public bool stopOnActionDone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				activationMode = s.Serialize<Enum_activationMode>(activationMode, name: "activationMode");
				stopOnZoneExit = s.Serialize<bool>(stopOnZoneExit, name: "stopOnZoneExit", options: CSerializerObject.Options.BoolAsByte);
				canRestartAction = s.Serialize<bool>(canRestartAction, name: "canRestartAction", options: CSerializerObject.Options.BoolAsByte);
				cutPreviousAction = s.Serialize<bool>(cutPreviousAction, name: "cutPreviousAction", options: CSerializerObject.Options.BoolAsByte);
				priority = s.Serialize<uint>(priority, name: "priority");
				saveBackward = s.Serialize<bool>(saveBackward, name: "saveBackward", options: CSerializerObject.Options.BoolAsByte);
				saveBackwardOnActionExit = s.Serialize<bool>(saveBackwardOnActionExit, name: "saveBackwardOnActionExit", options: CSerializerObject.Options.BoolAsByte);
				if (!canRestartAction) {
					stopOnActionDone = s.Serialize<bool>(stopOnActionDone, name: "stopOnActionDone", options: CSerializerObject.Options.BoolAsByte);
				}
			}
			public enum Enum_activationMode {
				[Serialize("Once_CheckpointReset"             )] Once_CheckpointReset = 0,
				[Serialize("Once"                             )] Once = 1,
				[Serialize("Multiple"                         )] Multiple = 2,
				[Serialize("Once_CheckpointReset_IfActionDone")] Once_CheckpointReset_IfActionDone = 3,
				[Serialize("Once_IfActionDone"                )] Once_IfActionDone = 4,
			}
		}
	}
}

