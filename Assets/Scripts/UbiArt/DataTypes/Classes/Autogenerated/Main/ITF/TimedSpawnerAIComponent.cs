namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerAIComponent : AIComponent {
		public TimedSpawnerData spawnData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnData = s.SerializeObject<TimedSpawnerData>(spawnData, name: "spawnData");
		}
		public override uint? ClassCRC => 0xF3FC1E91;
	}
}

