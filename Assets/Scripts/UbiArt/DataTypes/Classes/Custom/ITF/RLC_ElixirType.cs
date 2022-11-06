using UnityEngine;

namespace UbiArt.ITF {
	public enum RLC_ElixirType {
		[Serialize("RLC_ElixirType_UNKNOWN"          )] UNKNOWN = 0,
		[Serialize("RLC_ElixirType_SpeedHatching"    )] SpeedHatching = 1,
		[Serialize("RLC_ElixirType_UpgradeToUncommon")] UpgradeToUncommon = 2,
		[Serialize("RLC_ElixirType_UpgradeToRare"    )] UpgradeToRare = 3,
		[Serialize("RLC_ElixirType_ForceNewCreature" )] ForceNewCreature = 4,
		[Serialize("RLC_ElixirType_HatchNow"         )] HatchNow = 5,
		[Serialize("RLC_ElixirType_COUNT"            )] COUNT = 6,
	}
}

