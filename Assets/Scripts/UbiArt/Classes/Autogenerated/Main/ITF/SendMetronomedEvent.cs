using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SendMetronomedEvent : Event {
		[Serialize("WwiseMetronomeID")] public METRONOME_TYPE WwiseMetronomeID;
		[Serialize("WwisePlayAt"     )] public AUDIO_SYNC_PLAY WwisePlayAt;
		[Serialize("WwisePlayAtCue"  )] public StringID WwisePlayAtCue;
		[Serialize("onPlayEvent"     )] public Generic<Event> onPlayEvent;
		[Serialize("SendTo"          )] public ObjectPath SendTo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseMetronomeID));
			SerializeField(s, nameof(WwisePlayAt));
			SerializeField(s, nameof(WwisePlayAtCue));
			SerializeField(s, nameof(onPlayEvent));
			SerializeField(s, nameof(SendTo));
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		public enum AUDIO_SYNC_PLAY {
			[Serialize("AUDIO_SYNC_PLAY_IMMEDIATE"         )] IMMEDIATE = 0,
			[Serialize("AUDIO_SYNC_PLAY_AT_NEXT_GRID"      )] AT_NEXT_GRID = 1,
			[Serialize("AUDIO_SYNC_PLAY_AT_NEXT_BAR"       )] AT_NEXT_BAR = 2,
			[Serialize("AUDIO_SYNC_PLAY_AT_NEXT_BEAT"      )] AT_NEXT_BEAT = 3,
			[Serialize("AUDIO_SYNC_PLAY_AT_NEXT_CUE"       )] AT_NEXT_CUE = 4,
			[Serialize("AUDIO_SYNC_PLAY_AT_NEXT_CUSTOM_CUE")] AT_NEXT_CUSTOM_CUE = 5,
			[Serialize("AUDIO_SYNC_PLAY_AT_ENTRY_CUE"      )] AT_ENTRY_CUE = 6,
			[Serialize("AUDIO_SYNC_PLAY_AT_EXIT_CUE"       )] AT_EXIT_CUE = 7,
		}
		public override uint? ClassCRC => 0xC83242C0;
	}
}

