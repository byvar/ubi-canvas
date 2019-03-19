using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OpenCloseEyeAIComponent_Template : ActorComponent_Template {
		[Serialize("closedTimer")] public float closedTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(closedTimer));
		}
		public override uint? ClassCRC => 0x1DD64089;
	}
}

