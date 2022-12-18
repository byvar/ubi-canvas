namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCheckPointComponent : CheckpointComponent {
		public CListO<Vec2d> SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SpawnPos = s.SerializeObject<CListO<Vec2d>>(SpawnPos, name: "SpawnPos");
			}
		}
		public override uint? ClassCRC => 0x45E5F4C0;
	}
}

