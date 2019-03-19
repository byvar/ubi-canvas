using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TimeAttackFlagComponent_Template : ActorComponent_Template {
		[Serialize("waitTime")] public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitTime));
		}
		public override uint? ClassCRC => 0xF4E61B56;
	}
}

