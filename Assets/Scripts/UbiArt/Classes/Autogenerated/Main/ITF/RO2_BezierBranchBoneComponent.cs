using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchBoneComponent : RO2_BezierBranchComponent {
		public CListO<RO2_BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bones = s.SerializeObject<CListO<RO2_BezierBone>>(bones, name: "bones");
		}
		public override uint? ClassCRC => 0x3BED84D3;
	}
}

