using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_BezierBranchBaseRendererComponent : RO2_BezierBranchComponent {
		public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
		}
		public override uint? ClassCRC => 0x6276BABA;
	}
}

