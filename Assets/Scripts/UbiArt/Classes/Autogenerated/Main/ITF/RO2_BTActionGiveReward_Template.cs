using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionGiveReward_Template : BTAction_Template {
		[Serialize("anim"      )] public StringID anim;
		[Serialize("rewardPath")] public Path rewardPath;
		[Serialize("snapBone"  )] public StringID snapBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(rewardPath));
			SerializeField(s, nameof(snapBone));
		}
		public override uint? ClassCRC => 0x33806E40;
	}
}

