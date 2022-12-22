namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_BasicCreatureDisplay_Template : RO2_PowerUpDisplay_Template {
		public PathRef creatureActor;
		public Creature_Family creatureFamily;
		public Creature_Rarity creatureRarity;
		public bool isForbidden;
		public uint locId = uint.MaxValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creatureActor = s.SerializeObject<PathRef>(creatureActor, name: "creatureActor");
			creatureFamily = s.Serialize<Creature_Family>(creatureFamily, name: "creatureFamily");
			creatureRarity = s.Serialize<Creature_Rarity>(creatureRarity, name: "creatureRarity");
			isForbidden = s.Serialize<bool>(isForbidden, name: "isForbidden");
			locId = s.Serialize<uint>(locId, name: "locId");
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
		public enum Creature_Rarity {
			[Serialize("Creature_Rarity::common"   )] common = 0,
			[Serialize("Creature_Rarity::unCommon" )] unCommon = 1,
			[Serialize("Creature_Rarity::rare"     )] rare = 2,
			[Serialize("Creature_Rarity::epic"     )] epic = 3,
			[Serialize("Creature_Rarity::legendary")] legendary = 4,
			[Serialize("Creature_Rarity::queen"    )] queen = 5,
			[Serialize("Creature_Rarity::unknown"  )] unknown = 6,
		}
		public override uint? ClassCRC => 0xBCFEDDE6;
	}
}

