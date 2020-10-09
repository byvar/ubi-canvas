using UnityEngine;

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
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				stopOnNext = s.Serialize<uint>(stopOnNext, name: "stopOnNext");
				eventDelay = s.Serialize<float>(eventDelay, name: "eventDelay");
				priority = s.Serialize<uint>(priority, name: "priority");
				setPriority = s.Serialize<uint>(setPriority, name: "setPriority");
			} else {
			}
		}
		public override uint? ClassCRC => 0x88670D2A;
	}
}

