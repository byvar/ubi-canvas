using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayWwise_evtTemplate : SequenceEventWithActor_Template {
		public StringID WwiseEventGUID;
		public METRONOME_TYPE WwiseMetronomeID;
		public bool soundPlayAfterdestroy;
		public AUDIO_SYNC_PLAY WwisePlayAt;
		public StringID WwisePlayAtCue;
		public bool PlayOutsideTheSeqEvent;
		public bool PlayOnlyOnceBySequence;
		public LocalisationId SubtitlesLocalisationId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseEventGUID = s.SerializeObject<StringID>(WwiseEventGUID, name: "WwiseEventGUID");
			WwiseMetronomeID = s.Serialize<METRONOME_TYPE>(WwiseMetronomeID, name: "WwiseMetronomeID");
			soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterdestroy");
			WwisePlayAt = s.Serialize<AUDIO_SYNC_PLAY>(WwisePlayAt, name: "WwisePlayAt");
			WwisePlayAtCue = s.SerializeObject<StringID>(WwisePlayAtCue, name: "WwisePlayAtCue");
			PlayOutsideTheSeqEvent = s.Serialize<bool>(PlayOutsideTheSeqEvent, name: "PlayOutsideTheSeqEvent");
			PlayOnlyOnceBySequence = s.Serialize<bool>(PlayOnlyOnceBySequence, name: "PlayOnlyOnceBySequence");
			SubtitlesLocalisationId = s.SerializeObject<LocalisationId>(SubtitlesLocalisationId, name: "SubtitlesLocalisationId");
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
		public override uint? ClassCRC => 0x9A8347EB;
	}
}

