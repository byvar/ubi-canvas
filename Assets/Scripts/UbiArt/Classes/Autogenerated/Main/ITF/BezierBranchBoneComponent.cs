using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchBoneComponent : BezierBranchComponent {
		[Serialize("bones")] public CList<BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(bones));
			}
		}
		public override uint? ClassCRC => 0xEB3B53B8;
	}
}

