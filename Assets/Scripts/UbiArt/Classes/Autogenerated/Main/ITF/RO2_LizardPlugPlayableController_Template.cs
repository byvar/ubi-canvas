using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LizardPlugPlayableController_Template : ActorPlugPlayableController_Template {
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0x18481B19;
	}
}

