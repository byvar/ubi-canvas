using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TriggerBounceComponent : ActorComponent {
		[Serialize("useTargetActorScenePosZ")] public bool useTargetActorScenePosZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useTargetActorScenePosZ));
		}
		public override uint? ClassCRC => 0x8E86201A;
	}
}

