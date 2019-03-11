using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchBaseRendererComponent : BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
		}
		public override uint? ClassCRC => 0x5EB81DE3;
	}
}

