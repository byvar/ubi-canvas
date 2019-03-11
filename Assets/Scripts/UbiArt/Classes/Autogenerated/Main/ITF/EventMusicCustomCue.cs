using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventMusicCustomCue : Event {
		[Serialize("Metronome")] public METRONOME_TYPE Metronome;
		[Serialize("Cue"      )] public StringID Cue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Metronome));
			SerializeField(s, nameof(Cue));
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		public override uint? ClassCRC => 0xCE3CE051;
	}
}

