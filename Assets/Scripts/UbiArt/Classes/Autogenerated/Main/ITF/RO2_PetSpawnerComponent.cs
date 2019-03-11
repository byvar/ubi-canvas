using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetSpawnerComponent : ActorComponent {
		[Serialize("petModelID"   )] public int petModelID;
		[Serialize("spawnMaxCount")] public uint spawnMaxCount;
		[Serialize("petModelID"   )] public bool petModelID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(petModelID));
				SerializeField(s, nameof(spawnMaxCount));
			} else {
				SerializeField(s, nameof(petModelID));
				SerializeField(s, nameof(spawnMaxCount));
			}
		}
		public override uint? ClassCRC => 0x47053909;
	}
}

