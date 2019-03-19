using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureManager_Template : TemplateObj {
		[Serialize("creatures"                               )] public CMap<StringID, RLC_BasicCreatureDisplay_Template> creatures;
		[Serialize("families"                                )] public CList<RLC_CreatureFamily> families;
		[Serialize("startingCreaturesId"                     )] public CArray<StringID> startingCreaturesId;
		[Serialize("duplicateRewards"                        )] public CMap<uint, RLC_DuplicateReward> duplicateRewards;
		[Serialize("queenHatchPercentage"                    )] public float queenHatchPercentage;
		[Serialize("rarityDefinitions"                       )] public CMap<Creature_Rarity.Enum, Creature_Rarity> rarityDefinitions;
		[Serialize("foodDefinitions"                         )] public CMap<Creature_Food.Enum, Creature_Food> foodDefinitions;
		[Serialize("basketFrontPath"                         )] public Path basketFrontPath;
		[Serialize("basketBackPath"                          )] public Path basketBackPath;
		[Serialize("creatureSelectionCounterPath"            )] public Path creatureSelectionCounterPath;
		[Serialize("creatureLianaPath"                       )] public Path creatureLianaPath;
		[Serialize("creatureScoreRitualTextPath"             )] public Path creatureScoreRitualTextPath;
		[Serialize("hatchingSpline"                          )] public Spline hatchingSpline;
		[Serialize("percentageSpline"                        )] public Spline percentageSpline;
		[Serialize("newCreatureVsRarity"                     )] public bool newCreatureVsRarity;
		[Serialize("maxHatchFail_Queen"                      )] public uint maxHatchFail_Queen;
		[Serialize("maxHatchFail_NewCreature"                )] public uint maxHatchFail_NewCreature;
		[Serialize("duplicateRewardFrequency"                )] public uint duplicateRewardFrequency;
		[Serialize("creatureDebugEnabled"                    )] public bool creatureDebugEnabled;
		[Serialize("creatureLumRewardAmount"                 )] public uint creatureLumRewardAmount;
		[Serialize("creatureTimeRewardAmount"                )] public float creatureTimeRewardAmount;
		[Serialize("onboardingCreatureId_Intro"              )] public StringID onboardingCreatureId_Intro;
		[Serialize("onboardingCreatureId_FindCharlie"        )] public StringID onboardingCreatureId_FindCharlie;
		[Serialize("onboardingCreatureId_FindCharlieOptional")] public StringID onboardingCreatureId_FindCharlieOptional;
		[Serialize("onboardingCreatureId_LuckyTicket"        )] public StringID onboardingCreatureId_LuckyTicket;
		[Serialize("onboardingCreatureId_AdventureEgg1"      )] public StringID onboardingCreatureId_AdventureEgg1;
		[Serialize("onboardingCreatureId_AdventureEgg2"      )] public StringID onboardingCreatureId_AdventureEgg2;
		[Serialize("onboardingCreatureId_UseSilverElixir"    )] public StringID onboardingCreatureId_UseSilverElixir;
		[Serialize("onboardingCreatureId_AdventureEgg3"      )] public StringID onboardingCreatureId_AdventureEgg3;
		[Serialize("wakeAllCreatures"                        )] public bool wakeAllCreatures;
		[Serialize("creaturesDontExhaust"                    )] public bool creaturesDontExhaust;
		[Serialize("familyOfTheDay"                          )] public Creature_Family familyOfTheDay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creatures));
			SerializeField(s, nameof(families));
			SerializeField(s, nameof(startingCreaturesId));
			SerializeField(s, nameof(startingCreaturesId));
			SerializeField(s, nameof(duplicateRewards));
			SerializeField(s, nameof(queenHatchPercentage));
			SerializeField(s, nameof(rarityDefinitions));
			SerializeField(s, nameof(foodDefinitions));
			SerializeField(s, nameof(basketFrontPath));
			SerializeField(s, nameof(basketBackPath));
			SerializeField(s, nameof(creatureSelectionCounterPath));
			SerializeField(s, nameof(creatureLianaPath));
			SerializeField(s, nameof(creatureScoreRitualTextPath));
			SerializeField(s, nameof(hatchingSpline));
			SerializeField(s, nameof(percentageSpline));
			SerializeField(s, nameof(newCreatureVsRarity));
			SerializeField(s, nameof(maxHatchFail_Queen));
			SerializeField(s, nameof(maxHatchFail_NewCreature));
			SerializeField(s, nameof(duplicateRewardFrequency));
			SerializeField(s, nameof(creatureDebugEnabled));
			SerializeField(s, nameof(creatureLumRewardAmount));
			SerializeField(s, nameof(creatureTimeRewardAmount));
			SerializeField(s, nameof(onboardingCreatureId_Intro));
			SerializeField(s, nameof(onboardingCreatureId_FindCharlie));
			SerializeField(s, nameof(onboardingCreatureId_FindCharlieOptional));
			SerializeField(s, nameof(onboardingCreatureId_LuckyTicket));
			SerializeField(s, nameof(onboardingCreatureId_AdventureEgg1));
			SerializeField(s, nameof(onboardingCreatureId_AdventureEgg2));
			SerializeField(s, nameof(onboardingCreatureId_UseSilverElixir));
			SerializeField(s, nameof(onboardingCreatureId_AdventureEgg3));
			SerializeField(s, nameof(wakeAllCreatures));
			SerializeField(s, nameof(creaturesDontExhaust));
			SerializeField(s, nameof(familyOfTheDay));
		}
		public enum Creature_Family {
			[Serialize("Creature_Family::none"                 )] none = 0,
			[Serialize("Creature_Family::Magnet_Balloon"       )] Magnet_Balloon = 1,
			[Serialize("Creature_Family::Magnet_Banana"        )] Magnet_Banana = 2,
			[Serialize("Creature_Family::Magnet_Carrot"        )] Magnet_Carrot = 3,
			[Serialize("Creature_Family::Magnet_Quince"        )] Magnet_Quince = 4,
			[Serialize("Creature_Family::Magnet_Strawberry"    )] Magnet_Strawberry = 5,
			[Serialize("Creature_Family::Magnet_Tapiblue"      )] Magnet_Tapiblue = 6,
			[Serialize("Creature_Family::Magnet_Watermelon"    )] Magnet_Watermelon = 7,
			[Serialize("Creature_Family::Radar_Apricot"        )] Radar_Apricot = 8,
			[Serialize("Creature_Family::Radar_Citron"         )] Radar_Citron = 9,
			[Serialize("Creature_Family::Radar_Fluffy"         )] Radar_Fluffy = 10,
			[Serialize("Creature_Family::Radar_FuzzBall"       )] Radar_FuzzBall = 11,
			[Serialize("Creature_Family::Radar_Leek"           )] Radar_Leek = 12,
			[Serialize("Creature_Family::Radar_Petrol"         )] Radar_Petrol = 13,
			[Serialize("Creature_Family::Radar_Plum"           )] Radar_Plum = 14,
			[Serialize("Creature_Family::Radar_Rubber"         )] Radar_Rubber = 15,
			[Serialize("Creature_Family::Shield_Cactus"        )] Shield_Cactus = 16,
			[Serialize("Creature_Family::Shield_Charcoal"      )] Shield_Charcoal = 17,
			[Serialize("Creature_Family::Shield_Gum"           )] Shield_Gum = 18,
			[Serialize("Creature_Family::Shield_Jelly"         )] Shield_Jelly = 19,
			[Serialize("Creature_Family::Shield_Metal"         )] Shield_Metal = 20,
			[Serialize("Creature_Family::Shield_Mop"           )] Shield_Mop = 21,
			[Serialize("Creature_Family::Shield_RedPunk"       )] Shield_RedPunk = 22,
			[Serialize("Creature_Family::Shield_DarkFur"       )] Shield_DarkFur = 23,
			[Serialize("Creature_Family::Radar_Cauliflower"    )] Radar_Cauliflower = 24,
			[Serialize("Creature_Family::Radar_Rose"           )] Radar_Rose = 25,
			[Serialize("Creature_Family::Shield_Chocolate"     )] Shield_Chocolate = 26,
			[Serialize("Creature_Family::Magnet_Parrot"        )] Magnet_Parrot = 27,
			[Serialize("Creature_Family::Shield_Frog"          )] Shield_Frog = 28,
			[Serialize("Creature_Family::Magnet_Candy"         )] Magnet_Candy = 29,
			[Serialize("Creature_Family::Magnet_Sushi"         )] Magnet_Sushi = 30,
			[Serialize("Creature_Family::Radar_Tropical"       )] Radar_Tropical = 31,
			[Serialize("Creature_Family::Magnet_MagSummer"     )] Magnet_MagSummer = 32,
			[Serialize("Creature_Family::Shield_InvSummer"     )] Shield_InvSummer = 33,
			[Serialize("Creature_Family::Radar_Peacock"        )] Radar_Peacock = 34,
			[Serialize("Creature_Family::Magnet_Fig"           )] Magnet_Fig = 35,
			[Serialize("Creature_Family::Radar_Cat"            )] Radar_Cat = 38,
			[Serialize("Creature_Family::Shield_Mummy"         )] Shield_Mummy = 39,
			[Serialize("Creature_Family::Magnet_WooliesWinter" )] Magnet_WooliesWinter = 40,
			[Serialize("Creature_Family::Magnet_FrosteesWinter")] Magnet_FrosteesWinter = 41,
			[Serialize("Creature_Family::Radar_LoveBuds"       )] Radar_LoveBuds = 42,
			[Serialize("Creature_Family::Shield_TheGoodKnights")] Shield_TheGoodKnights = 43,
			[Serialize("Creature_Family::Magnet_Radashians"    )] Magnet_Radashians = 44,
			[Serialize("Creature_Family::Radar_Piniatos"       )] Radar_Piniatos = 45,
			[Serialize("Creature_Family::Shield_TheLuchadors"  )] Shield_TheLuchadors = 46,
			[Serialize("Creature_Family::Shield_ThePokies"     )] Shield_ThePokies = 47,
			[Serialize("Creature_Family::Magnet_TheShooShoos"  )] Magnet_TheShooShoos = 48,
			[Serialize("Creature_Family::Shield_TheSharkies"   )] Shield_TheSharkies = 49,
			[Serialize("Creature_Family::Shield_TheHotHeads"   )] Shield_TheHotHeads = 50,
			[Serialize("Creature_Family::Radar_TheBooooos"     )] Radar_TheBooooos = 51,
			[Serialize("Creature_Family::Radar_Frostbites"     )] Radar_Frostbites = 52,
			[Serialize("Creature_Family::Radar_Sphynx"         )] Radar_Sphynx = 53,
			[Serialize("Creature_Family::Shield_Anubis"        )] Shield_Anubis = 54,
			[Serialize("Creature_Family::Radar_TheFrankies"    )] Radar_TheFrankies = 55,
			[Serialize("Creature_Family::Radar_Koi"            )] Radar_Koi = 56,
			[Serialize("Creature_Family::Shield_Origami"       )] Shield_Origami = 57,
			[Serialize("Creature_Family::Magnet_Alien"         )] Magnet_Alien = 58,
		}
		public override uint? ClassCRC => 0x44474F7D;
	}
}

