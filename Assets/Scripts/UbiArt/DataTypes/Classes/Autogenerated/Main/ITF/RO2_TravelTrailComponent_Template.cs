namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TravelTrailComponent_Template : ActorComponent_Template {
		public AccelType accelType;
		public bool destroyOnEnd;
		public float durationBeforeDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			accelType = s.Serialize<AccelType>(accelType, name: "accelType");
			destroyOnEnd = s.Serialize<bool>(destroyOnEnd, name: "destroyOnEnd");
			durationBeforeDisable = s.Serialize<float>(durationBeforeDisable, name: "durationBeforeDisable");
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

