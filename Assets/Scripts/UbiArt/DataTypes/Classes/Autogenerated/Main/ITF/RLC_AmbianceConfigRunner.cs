namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfigRunner : RLC_AmbianceConfig {
		public Enum_GraphicalFamily GraphicalFamily;
		public Enum_GraphicalKit GraphicalKit;
		public Enum_MapType MapType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GraphicalFamily = s.Serialize<Enum_GraphicalFamily>(GraphicalFamily, name: "GraphicalFamily");
			GraphicalKit = s.Serialize<Enum_GraphicalKit>(GraphicalKit, name: "GraphicalKit");
			MapType = s.Serialize<Enum_MapType>(MapType, name: "MapType");
		}
		public enum Enum_GraphicalFamily {
			[Serialize("_unknown"     )] _unknown = 0,
			[Serialize("Shaolin"      )] Shaolin = 1,
			[Serialize("Medieval"     )] Medieval = 2,
			[Serialize("ToadStory"    )] ToadStory = 3,
			[Serialize("Desert"       )] Desert = 4,
			[Serialize("UnderWater"   )] UnderWater = 5,
			[Serialize("Greece"       )] Greece = 6,
			[Serialize("LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("Intro"        )] Intro = 8,
		}
		public enum Enum_GraphicalKit {
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
		public enum Enum_MapType {
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
		public override uint? ClassCRC => 0x23230E72;
	}
}

