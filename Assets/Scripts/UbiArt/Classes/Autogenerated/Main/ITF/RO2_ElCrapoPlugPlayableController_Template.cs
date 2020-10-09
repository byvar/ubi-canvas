using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ElCrapoPlugPlayableController_Template : ActorPlugPlayableController_Template {
		public float ejectSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectSpeed = s.Serialize<float>(ejectSpeed, name: "ejectSpeed");
		}
		public override uint? ClassCRC => 0xC1E70695;
	}
}

