using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventStopMusic : Event {
		[Serialize("metronomeType")] public uint metronomeType;
		[Serialize("fadeTime"     )] public float fadeTime;
		[Serialize("name"         )] public StringID name;
		[Serialize("fadeOutTime"  )] public float fadeOutTime;
		[Serialize("stopOnNext"   )] public uint stopOnNext;
		[Serialize("eventDelay"   )] public float eventDelay;
		[Serialize("priority"     )] public uint priority;
		[Serialize("setPriority"  )] public uint setPriority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(fadeTime));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(stopOnNext));
				SerializeField(s, nameof(eventDelay));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(setPriority));
			} else {
			}
		}
		public override uint? ClassCRC => 0x88670D2A;
	}
}

