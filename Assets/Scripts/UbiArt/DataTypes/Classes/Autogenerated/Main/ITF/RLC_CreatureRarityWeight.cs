using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureRarityWeight : CSerializable {
		public Creature_Rarity rarity;
		public uint weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rarity = s.Serialize<Creature_Rarity>(rarity, name: "rarity");
			weight = s.Serialize<uint>(weight, name: "weight");
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
	}
}

