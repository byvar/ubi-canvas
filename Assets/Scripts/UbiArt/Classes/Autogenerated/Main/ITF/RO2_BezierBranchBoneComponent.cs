using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchBoneComponent : RO2_BezierBranchComponent {
		[Serialize("bones")] public CList<RO2_BezierBone> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bones));
		}
		public override uint? ClassCRC => 0x3BED84D3;
	}
}

