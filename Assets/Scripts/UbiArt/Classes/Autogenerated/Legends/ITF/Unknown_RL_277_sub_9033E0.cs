using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_277_sub_9033E0 : ActorComponent {
		[Serialize("forcedAction"            )] public Enum_forcedAction forcedAction;
		[Serialize("followPlayer"            )] public bool followPlayer;
		[Serialize("followPlayerUseCamDir"   )] public bool followPlayerUseCamDir;
		[Serialize("autoAction"              )] public bool autoAction;
		[Serialize("useToTargetTravel"       )] public bool useToTargetTravel;
		[Serialize("toTargetTravel"          )] public RO2_TravelData toTargetTravel;
		[Serialize("gyroData"                )] public GyroData gyroData;
		[Serialize("holdToggleMode"          )] public bool holdToggleMode;
		[Serialize("holdDuringToTargetTravel")] public bool holdDuringToTargetTravel;
		[Serialize("canBackward"             )] public bool canBackward;
		[Serialize("canBackwardAnytime"      )] public bool canBackwardAnytime;
		[Serialize("actionTravel"            )] public RO2_TravelData actionTravel;
		[Serialize("activationData"          )] public ActivationData activationData;
		[Serialize("backward"                )] public int backward;
		[Serialize("enabled"                 )] public int enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(forcedAction));
				if (forcedAction == Enum_forcedAction.Value_1) {
					SerializeField(s, nameof(followPlayer), boolAsByte: true);
					if (followPlayer) {
						SerializeField(s, nameof(followPlayerUseCamDir), boolAsByte: true);
					}
				} else {
					SerializeField(s, nameof(autoAction), boolAsByte: true);
					SerializeField(s, nameof(useToTargetTravel), boolAsByte: true);
					if (useToTargetTravel) {
						SerializeField(s, nameof(toTargetTravel));
					}
					if (forcedAction == Enum_forcedAction.Value_4) {
						SerializeField(s, nameof(gyroData));
					} else if (forcedAction == Enum_forcedAction.Value_3) {
						SerializeField(s, nameof(holdToggleMode), boolAsByte: true);
						if (useToTargetTravel) {
							SerializeField(s, nameof(holdDuringToTargetTravel), boolAsByte: true);
						}
					}
				}
				if (forcedAction != Enum_forcedAction.Value_4) {
					SerializeField(s, nameof(canBackward), boolAsByte: true);
					if (canBackward) {
						SerializeField(s, nameof(canBackwardAnytime), boolAsByte: true);
					}
					SerializeField(s, nameof(actionTravel));
				}
				SerializeField(s, nameof(activationData));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(backward));
				SerializeField(s, nameof(enabled));
			}
		}
		public enum Enum_forcedAction {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0xA38389F8;

		[Games(GameFlags.RL)]
		public partial class GyroData : CSerializable {
			[Serialize("speed")] public Angle speed;
			[Serialize("accel")] public Angle accel;
			[Serialize("decel")] public Angle decel;
			[Serialize("invertRotation")] public bool invertRotation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(accel));
				SerializeField(s, nameof(decel));
				SerializeField(s, nameof(invertRotation), boolAsByte: true);
			}
		}

		[Games(GameFlags.RL)]
		public partial class ActivationData : CSerializable {
			[Serialize("activationMode"          )] public Enum_activationMode activationMode;
			[Serialize("stopOnZoneExit"          )] public bool stopOnZoneExit;
			[Serialize("canRestartAction"        )] public bool canRestartAction;
			[Serialize("cutPreviousAction"       )] public bool cutPreviousAction;
			[Serialize("priority"                )] public uint priority;
			[Serialize("saveBackward"            )] public bool saveBackward;
			[Serialize("saveBackwardOnActionExit")] public bool saveBackwardOnActionExit;
			[Serialize("stopOnActionDone"        )] public bool stopOnActionDone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(activationMode));
				SerializeField(s, nameof(stopOnZoneExit), boolAsByte: true);
				SerializeField(s, nameof(canRestartAction), boolAsByte: true);
				SerializeField(s, nameof(cutPreviousAction), boolAsByte: true);
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(saveBackward), boolAsByte: true);
				SerializeField(s, nameof(saveBackwardOnActionExit), boolAsByte: true);
				if (!canRestartAction) {
					SerializeField(s, nameof(stopOnActionDone), boolAsByte: true);
				}
			}
			public enum Enum_activationMode {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
				[Serialize("Value_3")] Value_3 = 3,
				[Serialize("Value_4")] Value_4 = 4,
			}
		}
	}
}

