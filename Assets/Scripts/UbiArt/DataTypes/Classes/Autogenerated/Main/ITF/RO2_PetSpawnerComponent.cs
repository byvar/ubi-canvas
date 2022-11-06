using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PetSpawnerComponent : ActorComponent {
		public int petModelID;
		public uint spawnMaxCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			petModelID = s.Serialize<int>(petModelID, name: "petModelID");
			spawnMaxCount = s.Serialize<uint>(spawnMaxCount, name: "spawnMaxCount");
		}
		public override uint? ClassCRC => 0x47053909;
	}
}

