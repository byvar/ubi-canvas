using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_TravelData : CSerializable {
		public float duration;
		public AccelType accelType;
		public SpeedType speedType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			accelType = s.Serialize<AccelType>(accelType, name: "accelType");
			speedType = s.Serialize<SpeedType>(speedType, name: "speedType");
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
		public enum SpeedType {
			[Serialize("SpeedType_Equal"   )] Equal = 0,
			[Serialize("SpeedType_Uniform" )] Uniform = 1,
			[Serialize("SpeedType_Specific")] Specific = 2,
		}
	}
}

