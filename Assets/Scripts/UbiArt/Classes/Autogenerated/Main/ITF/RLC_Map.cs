using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Map : CSerializable {
		[Serialize("Path"               )] public PathRef Path;
		[Serialize("ScoreRecapPath"     )] public PathRef ScoreRecapPath;
		[Serialize("Type"               )] public Enum_Type Type;
		[Serialize("Kit"                )] public Enum_Kit Kit;
		[Serialize("Mirrored"           )] public bool Mirrored;
		[Serialize("PlayableOnce"       )] public bool PlayableOnce;
		[Serialize("Difficulty"         )] public uint Difficulty;
		[Serialize("ScoreRecapMode"     )] public Enum_ScoreRecapMode ScoreRecapMode;
		[Serialize("ScoreRecapThreshold")] public CList<uint> ScoreRecapThreshold;
		[Serialize("MissionId"          )] public StringID MissionId;
		[Serialize("Spec"               )] public Enum_Spec Spec;
		[Serialize("InviteLocId"        )] public uint InviteLocId;
		[Serialize("TopologyId"         )] public StringID TopologyId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path));
			SerializeField(s, nameof(ScoreRecapPath));
			SerializeField(s, nameof(Type));
			SerializeField(s, nameof(Kit));
			SerializeField(s, nameof(Mirrored));
			SerializeField(s, nameof(PlayableOnce));
			SerializeField(s, nameof(Difficulty));
			SerializeField(s, nameof(ScoreRecapMode));
			SerializeField(s, nameof(ScoreRecapThreshold));
			SerializeField(s, nameof(MissionId));
			SerializeField(s, nameof(Spec));
			SerializeField(s, nameof(InviteLocId));
			SerializeField(s, nameof(TopologyId));
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

