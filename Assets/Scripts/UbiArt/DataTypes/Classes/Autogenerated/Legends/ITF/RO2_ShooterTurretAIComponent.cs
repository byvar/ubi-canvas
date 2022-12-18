namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterTurretAIComponent : RO2_MultiPiecesActorAIComponent {
		public TimedSpawnerData timedSpawnerData;
		public float fixedAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
			fixedAngle = s.Serialize<float>(fixedAngle, name: "fixedAngle");
		}
		public override uint? ClassCRC => 0x35663FAD;
	}
}

