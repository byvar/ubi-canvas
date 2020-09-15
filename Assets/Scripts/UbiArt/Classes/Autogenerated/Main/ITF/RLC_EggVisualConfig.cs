using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_EggVisualConfig : CSerializable {
		public Creature_Rarity Rarity;
		public PathRef eggToReachPath;
		public PathRef eggToChoosePath;
		public PathRef eggToCrackPath;
		public PathRef DecoyEggToCrackPath;
		public PathRef incubatorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rarity = s.Serialize<Creature_Rarity>(Rarity, name: "Rarity");
			eggToReachPath = s.SerializeObject<PathRef>(eggToReachPath, name: "eggToReachPath");
			eggToChoosePath = s.SerializeObject<PathRef>(eggToChoosePath, name: "eggToChoosePath");
			eggToCrackPath = s.SerializeObject<PathRef>(eggToCrackPath, name: "eggToCrackPath");
			DecoyEggToCrackPath = s.SerializeObject<PathRef>(DecoyEggToCrackPath, name: "DecoyEggToCrackPath");
			incubatorPath = s.SerializeObject<PathRef>(incubatorPath, name: "incubatorPath");
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

