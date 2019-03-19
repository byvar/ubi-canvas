using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BlackSwarmSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("activationDistance")] public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activationDistance));
		}
		public override uint? ClassCRC => 0x6B89EEF9;
	}
}

