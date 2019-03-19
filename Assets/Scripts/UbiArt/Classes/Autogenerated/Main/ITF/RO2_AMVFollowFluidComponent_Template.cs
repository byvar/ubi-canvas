using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AMVFollowFluidComponent_Template : ActorComponent_Template {
		[Serialize("maxInfluenceDst")] public float maxInfluenceDst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxInfluenceDst));
		}
		public override uint? ClassCRC => 0x0A7A511E;
	}
}

