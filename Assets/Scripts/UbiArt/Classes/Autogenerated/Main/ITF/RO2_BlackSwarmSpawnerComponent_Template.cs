using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BlackSwarmSpawnerComponent_Template : ActorComponent_Template {
		public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activationDistance = s.Serialize<float>(activationDistance, name: "activationDistance");
		}
		public override uint? ClassCRC => 0x6B89EEF9;
	}
}

