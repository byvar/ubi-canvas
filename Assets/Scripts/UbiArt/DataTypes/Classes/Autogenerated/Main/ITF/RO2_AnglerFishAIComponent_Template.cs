using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AnglerFishAIComponent_Template : RO2_SimpleAIComponent_Template {
		public StringID spawnBone;
		public Path lightSpawnPath;
		public float deathLightStopDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnBone = s.SerializeObject<StringID>(spawnBone, name: "spawnBone");
			lightSpawnPath = s.SerializeObject<Path>(lightSpawnPath, name: "lightSpawnPath");
			deathLightStopDelay = s.Serialize<float>(deathLightStopDelay, name: "deathLightStopDelay");
		}
		public override uint? ClassCRC => 0xCBBD19DB;
	}
}

