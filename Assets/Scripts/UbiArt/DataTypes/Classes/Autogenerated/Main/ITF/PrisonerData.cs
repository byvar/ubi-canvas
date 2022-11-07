namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class PrisonerData : CSerializable {
		public Path path;
		public bool isFree;
		public Index indexType;
		public Prisoner visualType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			path = s.SerializeObject<Path>(path, name: "path");
			isFree = s.Serialize<bool>(isFree, name: "isFree");
			indexType = s.Serialize<Index>(indexType, name: "indexType");
			visualType = s.Serialize<Prisoner>(visualType, name: "visualType");
		}
		public enum Index {
			[Serialize("Index_Map1")] Map1 = 0,
			[Serialize("Index_Map2")] Map2 = 1,
			[Serialize("Index_Map3")] Map3 = 2,
			[Serialize("Index_Map4")] Map4 = 3,
			[Serialize("Index_Map5")] Map5 = 4,
			[Serialize("Index_Map6")] Map6 = 5,
			[Serialize("Index_Map7")] Map7 = 6,
			[Serialize("Index_Map8")] Map8 = 7,
		}
		public enum Prisoner {
			[Serialize("Prisoner_Soldier" )] Soldier = 0,
			[Serialize("Prisoner_Baby"    )] Baby = 1,
			[Serialize("Prisoner_Fool"    )] Fool = 2,
			[Serialize("Prisoner_Princess")] Princess = 3,
			[Serialize("Prisoner_Prince"  )] Prince = 4,
			[Serialize("Prisoner_Queen"   )] Queen = 5,
			[Serialize("Prisoner_King"    )] King = 6,
		}
	}
}

