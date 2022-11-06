using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GardenCreatureFamily : CSerializable {
		public Garden_Creature_Family family;
		public uint locId;
		public CMap<cupsStringID_Key_Enum, StringID> cupsStringID;
		public StringID cupDiamondStringID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			family = s.Serialize<Garden_Creature_Family>(family, name: "family");
			locId = s.Serialize<uint>(locId, name: "locId");
			cupsStringID = s.SerializeObject<CMap<cupsStringID_Key_Enum, StringID>>(cupsStringID, name: "cupsStringID");
			cupDiamondStringID = s.SerializeObject<StringID>(cupDiamondStringID, name: "cupDiamondStringID");
		}
		public enum Garden_Creature_Family {
			[Serialize("Garden_Creature_Family::Unknown"    )] Unknown = 0,
			[Serialize("Garden_Creature_Family::Riverstream")] Riverstream = 1,
			[Serialize("Garden_Creature_Family::Burrow"     )] Burrow = 2,
			[Serialize("Garden_Creature_Family::Swamp"      )] Swamp = 3,
			[Serialize("Garden_Creature_Family::Trunk"      )] Trunk = 4,
			[Serialize("Garden_Creature_Family::Foliage"    )] Foliage = 5,
		}
		public enum cupsStringID_Key_Enum {
			[Serialize("unknown")] unknown = 0,
			[Serialize("bronze" )] bronze = 1,
			[Serialize("silver" )] silver = 2,
			[Serialize("gold"   )] gold = 3
		}
		public override uint? ClassCRC => 0x1717D6B8;
	}
}

