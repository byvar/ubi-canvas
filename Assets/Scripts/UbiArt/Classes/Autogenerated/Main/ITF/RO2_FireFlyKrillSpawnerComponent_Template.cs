using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FireFlyKrillSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("krillActorPath" )] public Path krillActorPath;
		[Serialize("detectionRadius")] public float detectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(krillActorPath));
			SerializeField(s, nameof(detectionRadius));
		}
		public override uint? ClassCRC => 0xF94397E6;
	}
}

