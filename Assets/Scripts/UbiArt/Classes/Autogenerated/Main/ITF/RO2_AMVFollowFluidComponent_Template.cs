using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AMVFollowFluidComponent_Template : ActorComponent_Template {
		public float maxInfluenceDst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxInfluenceDst = s.Serialize<float>(maxInfluenceDst, name: "maxInfluenceDst");
		}
		public override uint? ClassCRC => 0x0A7A511E;
	}
}

