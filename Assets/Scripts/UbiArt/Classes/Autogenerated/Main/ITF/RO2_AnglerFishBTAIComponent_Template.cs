using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AnglerFishBTAIComponent_Template : RO2_EnemyBTAIComponent_Template {
		[Serialize("spawnBone"          )] public StringID spawnBone;
		[Serialize("lightSpawnPath"     )] public Path lightSpawnPath;
		[Serialize("deathLightStopDelay")] public float deathLightStopDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnBone));
			SerializeField(s, nameof(lightSpawnPath));
			SerializeField(s, nameof(deathLightStopDelay));
		}
		public override uint? ClassCRC => 0xC21BC8E0;
	}
}

