using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_MultipassBranchRendererComponent : RO2_BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
		}
		public override uint? ClassCRC => 0xB3D2DBF2;
	}
}

