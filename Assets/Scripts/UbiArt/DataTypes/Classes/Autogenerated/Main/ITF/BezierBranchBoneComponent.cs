namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierBranchBoneComponent : BezierBranchComponent {
		public CListO<BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bones = s.SerializeObject<CListO<BezierBone>>(bones, name: "bones");
		}
		public override uint? ClassCRC => 0xEB3B53B8;
	}
}

