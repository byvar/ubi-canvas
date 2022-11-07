namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerModifierComponent_Template : ActorComponent_Template {
		public TimedSpawnerData timedSpawnerData;
		public bool useInstanceValues;
		public bool isTriggered;
		public Placeholder TimedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
				TimedSpawnerData = s.SerializeObject<Placeholder>(TimedSpawnerData, name: "TimedSpawnerData");
				useInstanceValues = s.Serialize<bool>(useInstanceValues, name: "useInstanceValues");
				isTriggered = s.Serialize<bool>(isTriggered, name: "isTriggered");
			} else {
				timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
				useInstanceValues = s.Serialize<bool>(useInstanceValues, name: "useInstanceValues");
				isTriggered = s.Serialize<bool>(isTriggered, name: "isTriggered");
			}
		}
		public override uint? ClassCRC => 0xD49FDDEC;
	}
}

