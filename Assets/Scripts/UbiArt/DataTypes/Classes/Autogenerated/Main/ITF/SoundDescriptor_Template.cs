namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.COL | GameFlags.VH | GameFlags.RA)]
	public partial class SoundDescriptor_Template : CSerializable {
		public StringID name;
		public bool soundPlayAfterdestroy;
		public StringID WwiseEventGUID;
		public METRONOME_TYPE WwiseMetronomeID = METRONOME_TYPE.INVALID;
		public AUDIO_SYNC_PLAY WwisePlayAt;
		public StringID WwisePlayAtCue;
		public StringID StringID__0;
		public Volume volume;
		public StringID category;
		public StringID limitCategory;
		public uint limitMode = 1;
		public uint maxInstances = uint.MaxValue;
		public int isStream;
		public CListO<Path> files;
		public SoundParams _params;
		public SoundGUID spawnEvent;
		public SoundGUID livingEvent;
		public SoundGUID deathEvent;
		public SoundGUID onEnterZone;
		public SoundGUID onExitZone;
		public LimiterDef.LimiterMode limitModeEnum = LimiterDef.LimiterMode.StopOldest;
		public int isPrefetched;
		public CListO<LocalizedPath> localizedFiles;
		public CListO<Path> filesIntro;
		public CListO<Path> filesBody;
		public CListO<Unknown_RL_12955_sub_591530> filesBodyOption;
		public CListO<Path> filesOutro;
		public Enum_serialPlayingMode serialPlayingMode;
		public Enum_serialStoppingMode serialStoppingMode;
		public uint pauseInsensitiveFlags;
		public uint outDevices = uint.MaxValue;
		public int soundPlayFadeAfterdestroy;
		public int noDrop;
		public uint Priority;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion == EngineVersion.RO) {
				name = s.SerializeObject<StringID>(name, name: "name");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				category = s.SerializeObject<StringID>(category, name: "category");
				limitCategory = s.SerializeObject<StringID>(limitCategory, name: "limitCategory");
				limitMode = s.Serialize<uint>(limitMode, name: "limitMode");
				maxInstances = s.Serialize<uint>(maxInstances, name: "maxInstances");
				isStream = s.Serialize<int>(isStream, name: "isStream");
				files = s.SerializeObject<CListO<Path>>(files, name: "files");
				_params = s.SerializeObject<SoundParams>(_params, name: "params");
			} else if (s.Settings.Game == Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				category = s.SerializeObject<StringID>(category, name: "category");
				limitCategory = s.SerializeObject<StringID>(limitCategory, name: "limitCategory");
				limitModeEnum = s.Serialize<LimiterDef.LimiterMode>(limitModeEnum, name: "limitMode");
				maxInstances = s.Serialize<uint>(maxInstances, name: "maxInstances");
				isStream = s.Serialize<int>(isStream, name: "isStream");
				isPrefetched = s.Serialize<int>(isPrefetched, name: "isPrefetched");
				files = s.SerializeObject<CListO<Path>>(files, name: "files");
				localizedFiles = s.SerializeObject<CListO<LocalizedPath>>(localizedFiles, name: "localizedFiles");
				filesIntro = s.SerializeObject<CListO<Path>>(filesIntro, name: "filesIntro");
				filesBody = s.SerializeObject<CListO<Path>>(filesBody, name: "filesBody");
				if (s.Settings.Platform != GamePlatform.Vita) {
					filesBodyOption = s.SerializeObject<CListO<Unknown_RL_12955_sub_591530>>(filesBodyOption, name: "filesBodyOption");
				}
				filesOutro = s.SerializeObject<CListO<Path>>(filesOutro, name: "filesOutro");
				serialPlayingMode = s.Serialize<Enum_serialPlayingMode>(serialPlayingMode, name: "serialPlayingMode");
				serialStoppingMode = s.Serialize<Enum_serialStoppingMode>(serialStoppingMode, name: "serialStoppingMode");
				_params = s.SerializeObject<SoundParams>(_params, name: "params");
				pauseInsensitiveFlags = s.Serialize<uint>(pauseInsensitiveFlags, name: "pauseInsensitiveFlags");
				outDevices = s.Serialize<uint>(outDevices, name: "outDevices");
				soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterdestroy");
				soundPlayFadeAfterdestroy = s.Serialize<int>(soundPlayFadeAfterdestroy, name: "soundPlayFadeAfterdestroy");
				if (s.Settings.Platform != GamePlatform.Vita) {
					noDrop = s.Serialize<int>(noDrop, name: "noDrop");
					Priority = s.Serialize<uint>(Priority, name: "Priority");
				}
			} else if(s.Settings.Game == Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				spawnEvent = s.SerializeObject<SoundGUID>(spawnEvent, name: "spawnEvent");
				livingEvent = s.SerializeObject<SoundGUID>(livingEvent, name: "livingEvent");
				deathEvent = s.SerializeObject<SoundGUID>(deathEvent, name: "deathEvent");
				onEnterZone = s.SerializeObject<SoundGUID>(onEnterZone, name: "onEnterZone");
				onExitZone = s.SerializeObject<SoundGUID>(onExitZone, name: "onExitZone");
				soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterDestroy", options: CSerializerObject.Options.BoolAsByte);
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterdestroy");
				WwiseEventGUID = s.SerializeObject<StringID>(WwiseEventGUID, name: "WwiseEventGUID");
				WwiseMetronomeID = s.Serialize<METRONOME_TYPE>(WwiseMetronomeID, name: "WwiseMetronomeID");
				WwisePlayAt = s.Serialize<AUDIO_SYNC_PLAY>(WwisePlayAt, name: "WwisePlayAt");
				WwisePlayAtCue = s.SerializeObject<StringID>(WwisePlayAtCue, name: "WwisePlayAtCue");
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
		public enum Enum_serialPlayingMode {
			[Serialize("PlayOrdered")] PlayOrdered = 0,
			[Serialize("PlayRandom")] PlayRandom = 1,
			[Serialize("PlayOrdered_RandomStart")] PlayOrdered_RandomStart = 2,
		}
		public enum Enum_serialStoppingMode {
			[Serialize("FinishCurrentSound")] FinishCurrentSound = 0,
			[Serialize("StopImmediate")] StopImmediate = 1,
		}
	}
}

