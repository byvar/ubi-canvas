using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class WwiseEngineEvent : CSerializable {
		public StringID GUID;
		public AUDIO_ENGEVT EngineType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GUID = s.SerializeObject<StringID>(GUID, name: "GUID");
			EngineType = s.Serialize<AUDIO_ENGEVT>(EngineType, name: "EngineType");
		}
		public enum AUDIO_ENGEVT {
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_GAMEPLAY"  )] WWISE_PAUSE_GAMEPLAY = 0,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_CUTSCENE"  )] WWISE_PAUSE_CUTSCENE = 1,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_MENU"      )] WWISE_PAUSE_MENU = 2,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_TRC"       )] WWISE_PAUSE_TRC = 3,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_VIDEO"     )] WWISE_PAUSE_VIDEO = 4,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_DEBUG"     )] WWISE_PAUSE_DEBUG = 5,
			[Serialize("AUDIO_ENGEVT_WWISE_PAUSE_WIIU"      )] WWISE_PAUSE_WIIU = 6,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_GAMEPLAY" )] WWISE_RESUME_GAMEPLAY = 7,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_CUTSCENE" )] WWISE_RESUME_CUTSCENE = 8,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_MENU"     )] WWISE_RESUME_MENU = 9,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_TRC"      )] WWISE_RESUME_TRC = 10,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_VIDEO"    )] WWISE_RESUME_VIDEO = 11,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_DEBUG"    )] WWISE_RESUME_DEBUG = 12,
			[Serialize("AUDIO_ENGEVT_WWISE_RESUME_WIIU"     )] WWISE_RESUME_WIIU = 13,
			[Serialize("AUDIO_ENGEVT_WWISE_STOP_ALL"        )] WWISE_STOP_ALL = 14,
			[Serialize("AUDIO_ENGEVT_WWISE_START_MAP"       )] WWISE_START_MAP = 15,
			[Serialize("AUDIO_ENGEVT_WWISE_MUTE_ALL"        )] WWISE_MUTE_ALL = 16,
			[Serialize("AUDIO_ENGEVT_WWISE_UNMUTE_ALL"      )] WWISE_UNMUTE_ALL = 17,
			[Serialize("AUDIO_ENGEVT_WWISE_CHECK_POINT_LOAD")] WWISE_CHECK_POINT_LOAD = 18,
			[Serialize("AUDIO_ENGEVT_WWISE_RELOAD_MAP"      )] WWISE_RELOAD_MAP = 19,
			[Serialize("AUDIO_ENGEVT_WWISE_HOT_RELOAD_MAP"  )] WWISE_HOT_RELOAD_MAP = 20,
			[Serialize("AUDIO_ENGEVT_WWISE_SKIP_CINE"       )] WWISE_SKIP_CINE = 21,
			[Serialize("AUDIO_ENGEVT_WWISE_QUITFROMGAME"    )] WWISE_QUITFROMGAME = 22,
			[Serialize("AUDIO_ENGEVT_COUNT"                 )] COUNT = 23,
		}
	}
}

