namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventPlayMusic : Event {
		public uint metronomeType;
		public StringID nodeName;
		public float fadeTime;
		public Volume volume;
		public uint playOnNext;
		public int stopAndPlay;
		public StringID name;
		public float fadeInTime;
		public float fadeOutTime;
		public float offsetTime;
		public float delay;
		public float eventDelay;
		public uint priority;
		public uint setPriority;
		public StringID bus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				nodeName = s.SerializeObject<StringID>(nodeName, name: "nodeName");
				fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				playOnNext = s.Serialize<uint>(playOnNext, name: "playOnNext");
				stopAndPlay = s.Serialize<int>(stopAndPlay, name: "stopAndPlay");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				nodeName = s.SerializeObject<StringID>(nodeName, name: "nodeName");
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				playOnNext = s.Serialize<uint>(playOnNext, name: "playOnNext");
				stopAndPlay = s.Serialize<int>(stopAndPlay, name: "stopAndPlay");
				offsetTime = s.Serialize<float>(offsetTime, name: "offsetTime");
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				delay = s.Serialize<float>(delay, name: "delay");
				eventDelay = s.Serialize<float>(eventDelay, name: "eventDelay");
				priority = s.Serialize<uint>(priority, name: "priority");
				setPriority = s.Serialize<uint>(setPriority, name: "setPriority");
			} else {
			}
		}
		public override uint? ClassCRC => 0x8964ECD0;
	}
}

