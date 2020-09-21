using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureManager_Template : TemplateObj {
		public CMap<StringID, RLC_BasicCreatureDisplay_Template> creatures;
		public CListO<RLC_CreatureFamily> families;
		public CArrayO<StringID> startingCreaturesId;
		public CMap<uint, RLC_DuplicateReward> duplicateRewards;
		public float queenHatchPercentage;
		public CMap<Creature_Rarity.Creature_Rarity_Enum, Creature_Rarity> rarityDefinitions;
		public CMap<Creature_Food.Enum, Creature_Food> foodDefinitions;
		public Path basketFrontPath;
		public Path basketBackPath;
		public Path creatureSelectionCounterPath;
		public Path creatureLianaPath;
		public Path creatureScoreRitualTextPath;
		public Spline hatchingSpline;
		public Spline percentageSpline;
		public bool newCreatureVsRarity;
		public uint maxHatchFail_Queen;
		public uint maxHatchFail_NewCreature;
		public uint duplicateRewardFrequency;
		public bool creatureDebugEnabled;
		public uint creatureLumRewardAmount;
		public float creatureTimeRewardAmount;
		public StringID onboardingCreatureId_Intro;
		public StringID onboardingCreatureId_FindCharlie;
		public StringID onboardingCreatureId_FindCharlieOptional;
		public StringID onboardingCreatureId_LuckyTicket;
		public StringID onboardingCreatureId_AdventureEgg1;
		public StringID onboardingCreatureId_AdventureEgg2;
		public StringID onboardingCreatureId_UseSilverElixir;
		public StringID onboardingCreatureId_AdventureEgg3;
		public bool wakeAllCreatures;
		public bool creaturesDontExhaust;
		public Creature_Family familyOfTheDay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creatures = s.SerializeObject<CMap<StringID, RLC_BasicCreatureDisplay_Template>>(creatures, name: "creatures");
			families = s.SerializeObject<CListO<RLC_CreatureFamily>>(families, name: "families");
			startingCreaturesId = s.SerializeObject<CArrayO<StringID>>(startingCreaturesId, name: "startingCreaturesId");
			startingCreaturesId = s.SerializeObject<CArrayO<StringID>>(startingCreaturesId, name: "startingCreaturesId");
			duplicateRewards = s.SerializeObject<CMap<uint, RLC_DuplicateReward>>(duplicateRewards, name: "duplicateRewards");
			queenHatchPercentage = s.Serialize<float>(queenHatchPercentage, name: "queenHatchPercentage");
			rarityDefinitions = s.SerializeObject<CMap<Creature_Rarity.Creature_Rarity_Enum, Creature_Rarity>>(rarityDefinitions, name: "rarityDefinitions");
			foodDefinitions = s.SerializeObject<CMap<Creature_Food.Enum, Creature_Food>>(foodDefinitions, name: "foodDefinitions");
			basketFrontPath = s.SerializeObject<Path>(basketFrontPath, name: "basketFrontPath");
			basketBackPath = s.SerializeObject<Path>(basketBackPath, name: "basketBackPath");
			creatureSelectionCounterPath = s.SerializeObject<Path>(creatureSelectionCounterPath, name: "creatureSelectionCounterPath");
			creatureLianaPath = s.SerializeObject<Path>(creatureLianaPath, name: "creatureLianaPath");
			creatureScoreRitualTextPath = s.SerializeObject<Path>(creatureScoreRitualTextPath, name: "creatureScoreRitualTextPath");
			hatchingSpline = s.SerializeObject<Spline>(hatchingSpline, name: "hatchingSpline");
			percentageSpline = s.SerializeObject<Spline>(percentageSpline, name: "percentageSpline");
			newCreatureVsRarity = s.Serialize<bool>(newCreatureVsRarity, name: "newCreatureVsRarity");
			maxHatchFail_Queen = s.Serialize<uint>(maxHatchFail_Queen, name: "maxHatchFail_Queen");
			maxHatchFail_NewCreature = s.Serialize<uint>(maxHatchFail_NewCreature, name: "maxHatchFail_NewCreature");
			duplicateRewardFrequency = s.Serialize<uint>(duplicateRewardFrequency, name: "duplicateRewardFrequency");
			creatureDebugEnabled = s.Serialize<bool>(creatureDebugEnabled, name: "creatureDebugEnabled");
			creatureLumRewardAmount = s.Serialize<uint>(creatureLumRewardAmount, name: "creatureLumRewardAmount");
			creatureTimeRewardAmount = s.Serialize<float>(creatureTimeRewardAmount, name: "creatureTimeRewardAmount");
			onboardingCreatureId_Intro = s.SerializeObject<StringID>(onboardingCreatureId_Intro, name: "onboardingCreatureId_Intro");
			onboardingCreatureId_FindCharlie = s.SerializeObject<StringID>(onboardingCreatureId_FindCharlie, name: "onboardingCreatureId_FindCharlie");
			onboardingCreatureId_FindCharlieOptional = s.SerializeObject<StringID>(onboardingCreatureId_FindCharlieOptional, name: "onboardingCreatureId_FindCharlieOptional");
			onboardingCreatureId_LuckyTicket = s.SerializeObject<StringID>(onboardingCreatureId_LuckyTicket, name: "onboardingCreatureId_LuckyTicket");
			onboardingCreatureId_AdventureEgg1 = s.SerializeObject<StringID>(onboardingCreatureId_AdventureEgg1, name: "onboardingCreatureId_AdventureEgg1");
			onboardingCreatureId_AdventureEgg2 = s.SerializeObject<StringID>(onboardingCreatureId_AdventureEgg2, name: "onboardingCreatureId_AdventureEgg2");
			onboardingCreatureId_UseSilverElixir = s.SerializeObject<StringID>(onboardingCreatureId_UseSilverElixir, name: "onboardingCreatureId_UseSilverElixir");
			onboardingCreatureId_AdventureEgg3 = s.SerializeObject<StringID>(onboardingCreatureId_AdventureEgg3, name: "onboardingCreatureId_AdventureEgg3");
			wakeAllCreatures = s.Serialize<bool>(wakeAllCreatures, name: "wakeAllCreatures");
			creaturesDontExhaust = s.Serialize<bool>(creaturesDontExhaust, name: "creaturesDontExhaust");
			familyOfTheDay = s.Serialize<Creature_Family>(familyOfTheDay, name: "familyOfTheDay");
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

