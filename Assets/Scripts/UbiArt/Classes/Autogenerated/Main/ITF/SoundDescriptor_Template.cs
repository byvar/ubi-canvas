using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class SoundDescriptor_Template : CSerializable {
		[Serialize("name"                 )] public StringID name;
		[Serialize("soundPlayAfterdestroy")] public bool soundPlayAfterdestroy;
		[Serialize("WwiseEventGUID"       )] public StringID WwiseEventGUID;
		[Serialize("WwiseMetronomeID"     )] public METRONOME_TYPE WwiseMetronomeID;
		[Serialize("WwisePlayAt"          )] public AUDIO_SYNC_PLAY WwisePlayAt;
		[Serialize("WwisePlayAtCue"       )] public StringID WwisePlayAtCue;
		[Serialize("StringID__0"          )] public StringID StringID__0;
		[Serialize("Volume__1"            )] public Volume Volume__1;
		[Serialize("StringID__2"          )] public StringID StringID__2;
		[Serialize("StringID__3"          )] public StringID StringID__3;
		[Serialize("uint__4"              )] public uint uint__4;
		[Serialize("uint__5"              )] public uint uint__5;
		[Serialize("int__6"               )] public int int__6;
		[Serialize("CList<Path>__7"       )] public CList<Path> CList_Path__7;
		[Serialize("SoundParams__8"       )] public SoundParams SoundParams__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(Volume__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(uint__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(CList_Path__7));
				SerializeField(s, nameof(SoundParams__8));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(soundPlayAfterdestroy));
				SerializeField(s, nameof(WwiseEventGUID));
				SerializeField(s, nameof(WwiseMetronomeID));
				SerializeField(s, nameof(WwisePlayAt));
				SerializeField(s, nameof(WwisePlayAtCue));
			}
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
	}
}

