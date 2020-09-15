using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_MultipassBranchRendererComponent : RO2_BezierBranchComponent {
		public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
		}
		public override uint? ClassCRC => 0xB3D2DBF2;
	}
}

