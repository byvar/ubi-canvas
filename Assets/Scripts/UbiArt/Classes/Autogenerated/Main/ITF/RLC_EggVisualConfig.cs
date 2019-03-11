using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_EggVisualConfig : CSerializable {
		[Serialize("Rarity"             )] public Creature_Rarity Rarity;
		[Serialize("eggToReachPath"     )] public PathRef eggToReachPath;
		[Serialize("eggToChoosePath"    )] public PathRef eggToChoosePath;
		[Serialize("eggToCrackPath"     )] public PathRef eggToCrackPath;
		[Serialize("DecoyEggToCrackPath")] public PathRef DecoyEggToCrackPath;
		[Serialize("incubatorPath"      )] public PathRef incubatorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rarity));
			SerializeField(s, nameof(eggToReachPath));
			SerializeField(s, nameof(eggToChoosePath));
			SerializeField(s, nameof(eggToCrackPath));
			SerializeField(s, nameof(DecoyEggToCrackPath));
			SerializeField(s, nameof(incubatorPath));
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
		public override uint? ClassCRC => 0xEDF30859;
	}
}

