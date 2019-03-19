using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Creature_Rarity : CSerializable {
		[Serialize("rarity"             )] public Creature_Rarity rarity;
		[Serialize("starConversionValue")] public uint starConversionValue;
		[Serialize("stepPercentage"     )] public float stepPercentage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rarity));
			SerializeField(s, nameof(starConversionValue));
			SerializeField(s, nameof(stepPercentage));
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

