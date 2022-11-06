using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DarkCreatureSpawnComponent_Template : ActorComponent_Template {
		public StringID SpawnSoundFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SpawnSoundFX = s.SerializeObject<StringID>(SpawnSoundFX, name: "SpawnSoundFX");
		}
		public override uint? ClassCRC => 0x3658BEE8;
	}
}

