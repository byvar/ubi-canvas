using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetSpawnerComponent : ActorComponent {
		[Serialize("petModelID"   )] public int petModelID;
		[Serialize("spawnMaxCount")] public uint spawnMaxCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(petModelID));
			SerializeField(s, nameof(spawnMaxCount));
		}
		public override uint? ClassCRC => 0x47053909;
	}
}

