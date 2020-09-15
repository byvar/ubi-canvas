using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Creature_Rarity : CSerializable {
		public Creature_Rarity_Enum rarity;
		public uint starConversionValue;
		public float stepPercentage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rarity = s.Serialize<Creature_Rarity_Enum>(rarity, name: "rarity");
			starConversionValue = s.Serialize<uint>(starConversionValue, name: "starConversionValue");
			stepPercentage = s.Serialize<float>(stepPercentage, name: "stepPercentage");
		}
		public enum Creature_Rarity_Enum {
			[Serialize("Creature_Rarity::common"   )] common = 0,
			[Serialize("Creature_Rarity::unCommon" )] unCommon = 1,
			[Serialize("Creature_Rarity::rare"     )] rare = 2,
			[Serialize("Creature_Rarity::epic"     )] epic = 3,
			[Serialize("Creature_Rarity::legendary")] legendary = 4,
			[Serialize("Creature_Rarity::queen"    )] queen = 5,
			[Serialize("Creature_Rarity::unknown"  )] unknown = 6,
		}
		public enum Enum {
			[Serialize("common"   )] common = 0,
			[Serialize("unCommon" )] unCommon = 1,
			[Serialize("rare"     )] rare = 2,
			[Serialize("epic"     )] epic = 3,
			[Serialize("legendary")] legendary = 4,
			[Serialize("queen"    )] queen = 5,
			[Serialize("unknown"  )] unknown = 6,
		}
	}
}

