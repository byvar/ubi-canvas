using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FireFlyKrillSpawnerComponent_Template : ActorComponent_Template {
		public Path krillActorPath;
		public float detectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			krillActorPath = s.SerializeObject<Path>(krillActorPath, name: "krillActorPath");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
		}
		public override uint? ClassCRC => 0xF94397E6;
	}
}

