using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_SocialManager : CSerializable {
		public enum eScreenShotType {
			[Serialize("ScreenShotType_unknown")] ScreenShotType_unknown = 0,
			[Serialize("ScreenShotType_HatchCreature")] ScreenShotType_HatchCreature = 1,
			[Serialize("ScreenShotType_WinLevelScore")] ScreenShotType_WinLevelScore = 2,
			[Serialize("ScreenShotType_WinLevelTimeAttack")] ScreenShotType_WinLevelTimeAttack = 3,
			[Serialize("ScreenShotType_ShareGameplayScreenshot")] ScreenShotType_ShareGameplayScreenshot = 4,
			[Serialize("ScreenShotType_RegionMap")] ScreenShotType_RegionMap = 5,
			[Serialize("ScreenShotType_RegionUnlocked")] ScreenShotType_RegionUnlocked = 6,
			[Serialize("ScreenShotType_EggRescued")] ScreenShotType_EggRescued = 7,
			[Serialize("ScreenShotType_AdventureComplete")] ScreenShotType_AdventureComplete = 8,
			[Serialize("ScreenShotType_FamilyReunited")] ScreenShotType_FamilyReunited = 9,
			[Serialize("ScreenShotType_CollectionComplete")] ScreenShotType_CollectionComplete = 10,
			[Serialize("ScreenShotType_TreeLevelUp")] ScreenShotType_TreeLevelUp = 11,
			[Serialize("ScreenShotType_FamilyShowcase")] ScreenShotType_FamilyShowcase = 12,
			[Serialize("ScreenShotType_CostumeShowcase")] ScreenShotType_CostumeShowcase = 13,
		}
	}
}

