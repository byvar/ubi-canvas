using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureSpawnComponent_Template : ActorComponent_Template {
		public StringID SpawnSoundFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SpawnSoundFX = s.SerializeObject<StringID>(SpawnSoundFX, name: "SpawnSoundFX");
		}
		public override uint? ClassCRC => 0x3658BEE8;
	}
}

