using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureSpawnComponent_Template : ActorComponent_Template {
		[Serialize("SpawnSoundFX")] public StringID SpawnSoundFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SpawnSoundFX));
		}
		public override uint? ClassCRC => 0x3658BEE8;
	}
}

