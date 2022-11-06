using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ToadPlugAIController_Template : ActorPlugAIController_Template {
		public float jumpImpulse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpImpulse = s.Serialize<float>(jumpImpulse, name: "jumpImpulse");
		}
		public override uint? ClassCRC => 0xDD45C958;
	}
}

