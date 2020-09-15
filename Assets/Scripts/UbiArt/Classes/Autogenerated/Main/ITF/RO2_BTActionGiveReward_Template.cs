using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionGiveReward_Template : BTAction_Template {
		public StringID anim;
		public Path rewardPath;
		public StringID snapBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			rewardPath = s.SerializeObject<Path>(rewardPath, name: "rewardPath");
			snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
		}
		public override uint? ClassCRC => 0x33806E40;
	}
}

