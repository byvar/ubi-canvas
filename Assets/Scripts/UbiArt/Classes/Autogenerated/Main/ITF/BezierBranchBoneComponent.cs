using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchBoneComponent : BezierBranchComponent {
		[Serialize("bones")] public CList<BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bones));
		}
		public override uint? ClassCRC => 0xEB3B53B8;
	}
}

