using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TravelTrailComponent_Template : ActorComponent_Template {
		[Serialize("accelType"            )] public AccelType accelType;
		[Serialize("destroyOnEnd"         )] public bool destroyOnEnd;
		[Serialize("durationBeforeDisable")] public float durationBeforeDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(accelType));
			SerializeField(s, nameof(destroyOnEnd));
			SerializeField(s, nameof(durationBeforeDisable));
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
		public override uint? ClassCRC => 0x92359EC9;
	}
}

