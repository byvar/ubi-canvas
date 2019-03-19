using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MapButton : RLC_BasicAdventureButton {
		[Serialize("Path"                      )] public PathRef Path;
		[Serialize("Type"                      )] public Enum_Type Type;
		[Serialize("Kit"                       )] public Enum_Kit Kit;
		[Serialize("isHardLevel"               )] public bool isHardLevel;
		[Serialize("DBG_ReloadConfig"          )] public bool DBG_ReloadConfig;
		[Serialize("DBG_AnimRewardValueEnabled")] public bool DBG_AnimRewardValueEnabled;
		[Serialize("DBG_AnimRewardValue"       )] public uint DBG_AnimRewardValue;
		[Serialize("currentPath"               )] public PathRef currentPath;
		[Serialize("currentType"               )] public Enum_currentType currentType;
		[Serialize("currentKit"                )] public Enum_currentKit currentKit;
		[Serialize("currentDifficulty"         )] public uint currentDifficulty;
		[Serialize("currentHistoryCpt"         )] public uint currentHistoryCpt;
		[Serialize("eventSentWhenSpawned"      )] public Generic<Event> eventSentWhenSpawned;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path));
			SerializeField(s, nameof(Type));
			SerializeField(s, nameof(Kit));
			SerializeField(s, nameof(isHardLevel));
			SerializeField(s, nameof(DBG_ReloadConfig));
			SerializeField(s, nameof(DBG_AnimRewardValueEnabled));
			SerializeField(s, nameof(DBG_AnimRewardValue));
			if (s.HasFlags(SerializeFlags.Flags16)) {
				SerializeField(s, nameof(currentPath));
				SerializeField(s, nameof(currentType));
				SerializeField(s, nameof(currentKit));
				SerializeField(s, nameof(currentDifficulty));
				SerializeField(s, nameof(currentHistoryCpt));
			}
			SerializeField(s, nameof(eventSentWhenSpawned));
		}
		public enum Enum_Type {
			[Serialize("_unknown"         )] _unknown = 0,
			[Serialize("Lums"             )] Lums = 1,
			[Serialize("Enemies"          )] Enemies = 2,
			[Serialize("Exploration"      )] Exploration = 3,
			[Serialize("TimeTrial"        )] TimeTrial = 4,
			[Serialize("Puzzle"           )] Puzzle = 5,
			[Serialize("HideNSeek"        )] HideNSeek = 6,
			[Serialize("Soccer"           )] Soccer = 7,
			[Serialize("AdversarialSoccer")] AdversarialSoccer = 8,
		}
		public enum Enum_Kit {
			[Serialize("_unknown"                   )] _unknown = 0,
			[Serialize("Dojo"                       )] Dojo = 1,
			[Serialize("SnowyMountain"              )] SnowyMountain = 2,
			[Serialize("BabelTower"                 )] BabelTower = 3,
			[Serialize("LandOfTheDead"              )] LandOfTheDead = 4,
			[Serialize("CastleInterior"             )] CastleInterior = 5,
			[Serialize("CastleExterior"             )] CastleExterior = 6,
			[Serialize("Swamp"                      )] Swamp = 7,
			[Serialize("EnchantedForest"            )] EnchantedForest = 8,
			[Serialize("BeanStalk"                  )] BeanStalk = 9,
			[Serialize("Avatar"                     )] Avatar = 10,
			[Serialize("_deprecated_OvergrownTemple")] _deprecated_OvergrownTemple = 11,
			[Serialize("MexicanParty"               )] MexicanParty = 12,
			[Serialize("_deprecated_CakeParty"      )] _deprecated_CakeParty = 13,
			[Serialize("_deprecated_Garbage"        )] _deprecated_Garbage = 14,
			[Serialize("Hangar"                     )] Hangar = 15,
			[Serialize("Nemo"                       )] Nemo = 16,
			[Serialize("Olympus"                    )] Olympus = 17,
			[Serialize("_deprecated_Palace"         )] _deprecated_Palace = 18,
			[Serialize("Hades"                      )] Hades = 19,
			[Serialize("Maze"                       )] Maze = 20,
			[Serialize("Intro"                      )] Intro = 21,
			[Serialize("HauntedCastle"              )] HauntedCastle = 22,
			[Serialize("DemoMix"                    )] DemoMix = 23,
			[Serialize("Temple"                     )] Temple = 24,
			[Serialize("OpenOcean"                  )] OpenOcean = 25,
			[Serialize("AncientRuins"               )] AncientRuins = 26,
			[Serialize("Urban"                      )] Urban = 27,
			[Serialize("Rural"                      )] Rural = 28,
		}
		public override uint? ClassCRC => 0x71F3C5CE;
	}
}

