using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierBranchBaseRendererComponent : RO2_BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
		}
		public override uint? ClassCRC => 0x6276BABA;
	}
}

