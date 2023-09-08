namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventStopMusic : Event {
		public uint metronomeType;
		public float fadeTime;
		public StringID name;
		public float fadeOutTime;
		public uint stopOnNext;
		public float eventDelay;
		public uint priority;
		public uint setPriority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				stopOnNext = s.Serialize<uint>(stopOnNext, name: "stopOnNext");
				eventDelay = s.Serialize<float>(eventDelay, name: "eventDelay");
				priority = s.Serialize<uint>(priority, name: "priority");
				if (s.Settings.Platform != GamePlatform.Vita) {
					setPriority = s.Serialize<uint>(setPriority, name: "setPriority");
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0x88670D2A;
	}
}

