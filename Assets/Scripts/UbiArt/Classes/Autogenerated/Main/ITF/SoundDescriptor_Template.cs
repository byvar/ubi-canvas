using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.COL)]
	public partial class SoundDescriptor_Template : CSerializable {
		[Serialize("name"                 )] public StringID name;
		[Serialize("soundPlayAfterdestroy")] public bool soundPlayAfterdestroy;
		[Serialize("WwiseEventGUID"       )] public StringID WwiseEventGUID;
		[Serialize("WwiseMetronomeID"     )] public METRONOME_TYPE WwiseMetronomeID;
		[Serialize("WwisePlayAt"          )] public AUDIO_SYNC_PLAY WwisePlayAt;
		[Serialize("WwisePlayAtCue"       )] public StringID WwisePlayAtCue;
		[Serialize("StringID__0"          )] public StringID StringID__0;
		[Serialize("Volume__1"            )] public Volume volume;
		[Serialize("category"             )] public StringID category;
		[Serialize("limitCategory"        )] public StringID limitCategory;
		[Serialize("limitMode"            )] public uint limitMode;
		[Serialize("maxInstances"         )] public uint maxInstances;
		[Serialize("isStream"             )] public int isStream;
		[Serialize("CList<Path>__7"       )] public CList<Path> files;
		[Serialize("SoundParams__8"       )] public SoundParams _params;
		[Serialize("spawnEvent"           )] public SoundGUID spawnEvent;
		[Serialize("livingEvent"          )] public SoundGUID livingEvent;
		[Serialize("deathEvent"           )] public SoundGUID deathEvent;
		[Serialize("onEnterZone"          )] public SoundGUID onEnterZone;
		[Serialize("onExitZone"           )] public SoundGUID onExitZone;
		[Serialize("soundPlayAfterDestroy")] public bool soundPlayAfterDestroy;
		[Serialize("limitMode"                )] public Enum_limitMode limitModeEnum;
		[Serialize("isPrefetched"             )] public int isPrefetched;
		[Serialize("localizedFiles"           )] public CList<LocalizedPath> localizedFiles;
		[Serialize("filesIntro"               )] public CList<Path> filesIntro;
		[Serialize("filesBody"                )] public CList<Path> filesBody;
		[Serialize("filesBodyOption"          )] public CList<Unknown_RL_12955_sub_591530> filesBodyOption;
		[Serialize("filesOutro"               )] public CList<Path> filesOutro;
		[Serialize("serialPlayingMode"        )] public Enum_serialPlayingMode serialPlayingMode;
		[Serialize("serialStoppingMode"       )] public Enum_serialStoppingMode serialStoppingMode;
		[Serialize("pauseInsensitiveFlags"    )] public uint pauseInsensitiveFlags;
		[Serialize("outDevices"               )] public uint outDevices;
		[Serialize("soundPlayFadeAfterdestroy")] public int soundPlayFadeAfterdestroy;
		[Serialize("noDrop"                   )] public int noDrop;
		[Serialize("Priority"                 )] public uint Priority;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(category));
				SerializeField(s, nameof(limitCategory));
				SerializeField(s, nameof(limitMode));
				SerializeField(s, nameof(maxInstances));
				SerializeField(s, nameof(isStream));
				SerializeField(s, nameof(files));
				SerializeField(s, nameof(_params));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(category));
				SerializeField(s, nameof(limitCategory));
				SerializeField(s, nameof(limitModeEnum));
				SerializeField(s, nameof(maxInstances));
				SerializeField(s, nameof(isStream));
				SerializeField(s, nameof(isPrefetched));
				SerializeField(s, nameof(files));
				SerializeField(s, nameof(localizedFiles));
				SerializeField(s, nameof(filesIntro));
				SerializeField(s, nameof(filesBody));
				SerializeField(s, nameof(filesBodyOption));
				SerializeField(s, nameof(filesOutro));
				SerializeField(s, nameof(serialPlayingMode));
				SerializeField(s, nameof(serialStoppingMode));
				SerializeField(s, nameof(_params));
				SerializeField(s, nameof(pauseInsensitiveFlags));
				SerializeField(s, nameof(outDevices));
				SerializeField(s, nameof(soundPlayAfterdestroy));
				SerializeField(s, nameof(soundPlayFadeAfterdestroy));
				SerializeField(s, nameof(noDrop));
				SerializeField(s, nameof(Priority));
			} else if(Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(spawnEvent));
				SerializeField(s, nameof(livingEvent));
				SerializeField(s, nameof(deathEvent));
				SerializeField(s, nameof(onEnterZone));
				SerializeField(s, nameof(onExitZone));
				SerializeField(s, nameof(soundPlayAfterDestroy), boolAsByte: true);
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
		public enum Enum_limitMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_serialPlayingMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_serialStoppingMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
	}
}

