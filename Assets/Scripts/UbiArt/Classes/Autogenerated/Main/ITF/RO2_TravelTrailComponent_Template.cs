using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TravelTrailComponent_Template : ActorComponent_Template {
		[Serialize("accelType"            )] public AccelType accelType;
		[Serialize("destroyOnEnd"         )] public bool destroyOnEnd;
		[Serialize("durationBeforeDisable")] public float durationBeforeDisable;
		[Serialize("accelType"            )] public Enum_accelType accelType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(accelType));
				SerializeField(s, nameof(destroyOnEnd));
				SerializeField(s, nameof(durationBeforeDisable));
			} else {
				SerializeField(s, nameof(accelType));
				SerializeField(s, nameof(destroyOnEnd));
				SerializeField(s, nameof(durationBeforeDisable));
			}
		}
		public enum AccelType {
			[Serialize("AccelType_Linear")] Linear = 0,
			[Serialize("AccelType_X2"    )] X2 = 1,
			[Serialize("AccelType_X3"    )] X3 = 2,
			[Serialize("AccelType_X4"    )] X4 = 3,
			[Serialize("AccelType_X5"    )] X5 = 4,
			[Serialize("AccelType_InvX2" )] InvX2 = 5,
			[Serialize("AccelType_InvX3" )] InvX3 = 6,
			[Serialize("AccelType_InvX4" )] InvX4 = 7,
			[Serialize("AccelType_InvX5" )] InvX5 = 8,
		}
		public enum Enum_accelType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x92359EC9;
	}
}

