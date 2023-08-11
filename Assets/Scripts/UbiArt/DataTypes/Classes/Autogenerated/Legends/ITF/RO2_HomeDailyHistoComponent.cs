namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Used for challenge historic (e.g. dailyhistoric)
	public partial class RO2_HomeDailyHistoComponent : RO2_HomeComponent {
		public float nodePaintingOffsetY;
		public CompetitionFrequency frequency;
		public Vec3d currentOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodePaintingOffsetY = s.Serialize<float>(nodePaintingOffsetY, name: "nodePaintingOffsetY");
			frequency = s.Serialize<CompetitionFrequency>(frequency, name: "frequency");
			if (s.HasFlags(SerializeFlags.Editor)) {
				currentOffset = s.SerializeObject<Vec3d>(currentOffset, name: "currentOffset");
			}
		}
		public enum CompetitionFrequency {
			[Serialize("online::CompetitionFrequency_Daily"        )] Daily = 0,
			[Serialize("online::CompetitionFrequency_Weekly"       )] Weekly = 1,
			[Serialize("online::CompetitionFrequency_Daily_Expert" )] Daily_Expert = 2,
			[Serialize("online::CompetitionFrequency_Weekly_Expert")] Weekly_Expert = 3,
			[Serialize("online::CompetitionFrequency_None"         )] None = -1,
		}
		public override uint? ClassCRC => 0xFBA59E84;
	}
}

