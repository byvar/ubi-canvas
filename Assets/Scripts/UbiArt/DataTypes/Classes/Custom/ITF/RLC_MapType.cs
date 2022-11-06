using UnityEngine;

namespace UbiArt.ITF {
	public enum RLC_MapType {
		[Serialize("RLC_MapType_Unknown"          )] Unknown = 0,
		[Serialize("RLC_MapType_Lums"             )] Lums = 1,
		[Serialize("RLC_MapType_Enemies"          )] Enemies = 2,
		[Serialize("RLC_MapType_Exploration"      )] Exploration = 3,
		[Serialize("RLC_MapType_TimeTrial"        )] TimeTrial = 4,
		[Serialize("RLC_MapType_Puzzle"           )] Puzzle = 5,
		[Serialize("RLC_MapType_HideNSeek"        )] HideNSeek = 6,
		[Serialize("RLC_MapType_Soccer"           )] Soccer = 7,
		[Serialize("RLC_MapType_AdversarialSoccer")] AdversarialSoccer = 8,
		[Serialize("RLC_MapType_Count"            )] Count = 9,
	}
}

