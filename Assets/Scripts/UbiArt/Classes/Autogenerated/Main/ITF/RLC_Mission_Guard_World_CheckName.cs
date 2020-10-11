using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_World_CheckName : CSerializable {
		public Enum_worldName worldName;
		public bool nextWorld;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			worldName = s.Serialize<Enum_worldName>(worldName, name: "worldName");
			nextWorld = s.Serialize<bool>(nextWorld, name: "nextWorld");
		}
		public enum Enum_worldName {
			[Serialize("Riverstream")] Riverstream = 0,
			[Serialize("Burrow"     )] Burrow = 1,
			[Serialize("Swamp"      )] Swamp = 2,
			[Serialize("Trunk"      )] Trunk = 3,
			[Serialize("Foliage"    )] Foliage = 4,
			[Serialize("Bonus"      )] Bonus = 5,
		}
		public override uint? ClassCRC => 0x68379C6D;
	}
}

