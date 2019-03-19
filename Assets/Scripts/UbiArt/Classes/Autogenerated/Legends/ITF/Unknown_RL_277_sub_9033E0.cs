using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_277_sub_9033E0 : CSerializable {
		[Serialize("forcedAction"            )] public Enum_forcedAction forcedAction;
		[Serialize("followPlayer"            )] public bool followPlayer;
		[Serialize("followPlayerUseCamDir"   )] public bool followPlayerUseCamDir;
		[Serialize("autoAction"              )] public bool autoAction;
		[Serialize("useToTargetTravel"       )] public bool useToTargetTravel;
		[Serialize("toTargetTravel"          )] public Placeholder toTargetTravel;
		[Serialize("gyroData"                )] public Placeholder gyroData;
		[Serialize("holdToggleMode"          )] public bool holdToggleMode;
		[Serialize("holdDuringToTargetTravel")] public bool holdDuringToTargetTravel;
		[Serialize("canBackward"             )] public bool canBackward;
		[Serialize("canBackwardAnytime"      )] public bool canBackwardAnytime;
		[Serialize("actionTravel"            )] public Placeholder actionTravel;
		[Serialize("activationData"          )] public Placeholder activationData;
		[Serialize("backward"                )] public int backward;
		[Serialize("enabled"                 )] public int enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(forcedAction));
				SerializeField(s, nameof(followPlayer), boolAsByte: true);
				SerializeField(s, nameof(followPlayerUseCamDir), boolAsByte: true);
				SerializeField(s, nameof(autoAction), boolAsByte: true);
				SerializeField(s, nameof(useToTargetTravel), boolAsByte: true);
				SerializeField(s, nameof(toTargetTravel));
				SerializeField(s, nameof(gyroData));
				SerializeField(s, nameof(holdToggleMode), boolAsByte: true);
				SerializeField(s, nameof(holdDuringToTargetTravel), boolAsByte: true);
				SerializeField(s, nameof(canBackward), boolAsByte: true);
				SerializeField(s, nameof(canBackwardAnytime), boolAsByte: true);
				SerializeField(s, nameof(actionTravel));
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
	}
}

