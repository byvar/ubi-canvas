namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GardenCreature : CSerializable {
		public bool isFree;
		public bool canBeCollected;
		public uint id;
		public Garden_Creature_Family familyType;
		public Garden_Creature_Rarity creatureRarity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isFree = s.Serialize<bool>(isFree, name: "isFree");
			canBeCollected = s.Serialize<bool>(canBeCollected, name: "canBeCollected");
			id = s.Serialize<uint>(id, name: "id");
			familyType = s.Serialize<Garden_Creature_Family>(familyType, name: "familyType");
			creatureRarity = s.Serialize<Garden_Creature_Rarity>(creatureRarity, name: "creatureRarity");
		}
		public enum Garden_Creature_Family {
			[Serialize("Garden_Creature_Family::Unknown"    )] Unknown = 0,
			[Serialize("Garden_Creature_Family::Riverstream")] Riverstream = 1,
			[Serialize("Garden_Creature_Family::Burrow"     )] Burrow = 2,
			[Serialize("Garden_Creature_Family::Swamp"      )] Swamp = 3,
			[Serialize("Garden_Creature_Family::Trunk"      )] Trunk = 4,
			[Serialize("Garden_Creature_Family::Foliage"    )] Foliage = 5,
		}
		public enum Garden_Creature_Rarity {
			[Serialize("Garden_Creature_Rarity::unknown")] unknown = 0,
			[Serialize("Garden_Creature_Rarity::bronze" )] bronze = 1,
			[Serialize("Garden_Creature_Rarity::silver" )] silver = 2,
			[Serialize("Garden_Creature_Rarity::gold"   )] gold = 3,
		}
		public override uint? ClassCRC => 0xC5D21EF0;
	}
}

