using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ElCrapoPlugPlayableController_Template : ActorPlugPlayableController_Template {
		[Serialize("ejectSpeed")] public float ejectSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectSpeed));
		}
		public override uint? ClassCRC => 0xC1E70695;
	}
}

