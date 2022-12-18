namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Used for challenge historic (e.g. dailyhistoric)
	public partial class RO2_HomeDailyHistoComponent : RO2_HomeComponent {
		public float nodePaintingOffsetY;
		public Enum_frequency frequency;
		public Vec3d currentOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodePaintingOffsetY = s.Serialize<float>(nodePaintingOffsetY, name: "nodePaintingOffsetY");
			frequency = s.Serialize<Enum_frequency>(frequency, name: "frequency");
			if (s.HasFlags(SerializeFlags.Editor)) {
				currentOffset = s.SerializeObject<Vec3d>(currentOffset, name: "currentOffset");
			}
		}
		public enum Enum_frequency {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xFBA59E84;
	}
}

