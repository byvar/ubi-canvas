using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchBoneComponent : BezierBranchComponent {
		public CList<BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				bones = s.SerializeObject<CList<BezierBone>>(bones, name: "bones");
			}
		}
		public override uint? ClassCRC => 0xEB3B53B8;
	}
}

