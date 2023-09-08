namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Map : CSerializable {
		public uint LineIdName;
		public PathRef Path;
		public PathRef ScoreRecapPath;
		public Enum_Type Type;
		public Enum_Kit Kit;
		public bool Mirrored;
		public bool Boss;
		public bool PlayableOnce;
		public uint Difficulty;
		public Enum_ScoreRecapMode ScoreRecapMode;
		public CListP<uint> ScoreRecapThreshold;
		public StringID MissionId;
		public Enum_Spec Spec;
		public uint InviteLocId;
		public StringID TopologyId;
		public uint GoldRequirement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RM) {
				LineIdName = s.Serialize<uint>(LineIdName, name: "LineIdName");
				Path = s.SerializeObject<PathRef>(Path, name: "Path");
				ScoreRecapPath = s.SerializeObject<PathRef>(ScoreRecapPath, name: "ScoreRecapPath");
				Type = s.Serialize<Enum_Type>(Type, name: "Type");
				Mirrored = s.Serialize<bool>(Mirrored, name: "Mirrored");
				Boss = s.Serialize<bool>(Boss, name: "Boss");
				Spec = s.Serialize<Enum_Spec>(Spec, name: "Spec");
				GoldRequirement = s.Serialize<uint>(GoldRequirement, name: "GoldRequirement");
			} else {
				Path = s.SerializeObject<PathRef>(Path, name: "Path");
				ScoreRecapPath = s.SerializeObject<PathRef>(ScoreRecapPath, name: "ScoreRecapPath");
				Type = s.Serialize<Enum_Type>(Type, name: "Type");
				Kit = s.Serialize<Enum_Kit>(Kit, name: "Kit");
				Mirrored = s.Serialize<bool>(Mirrored, name: "Mirrored");
				PlayableOnce = s.Serialize<bool>(PlayableOnce, name: "PlayableOnce");
				Difficulty = s.Serialize<uint>(Difficulty, name: "Difficulty");
				ScoreRecapMode = s.Serialize<Enum_ScoreRecapMode>(ScoreRecapMode, name: "ScoreRecapMode");
				ScoreRecapThreshold = s.SerializeObject<CListP<uint>>(ScoreRecapThreshold, name: "ScoreRecapThreshold");
				MissionId = s.SerializeObject<StringID>(MissionId, name: "MissionId");
				Spec = s.Serialize<Enum_Spec>(Spec, name: "Spec");
				InviteLocId = s.Serialize<uint>(InviteLocId, name: "InviteLocId");
				TopologyId = s.SerializeObject<StringID>(TopologyId, name: "TopologyId");
			}
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
		public enum Enum_ScoreRecapMode {
			[Serialize("_unknown")] _unknown = 0,
			[Serialize("Lums"    )] Lums = 1,
			[Serialize("Timer"   )] Timer = 2,
		}
		public enum Enum_Spec {
			[Serialize("_none"    )] _none = 0,
			[Serialize("Challenge")] Challenge = 1,
			[Serialize("Queen"    )] Queen = 2,
			[Serialize("Bonus"    )] Bonus = 3,
		}
		public override uint? ClassCRC => 0x507D8544;
	}
}

