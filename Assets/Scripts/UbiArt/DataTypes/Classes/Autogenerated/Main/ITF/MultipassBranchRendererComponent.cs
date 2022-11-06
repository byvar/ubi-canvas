using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class MultipassBranchRendererComponent : BezierBranchComponent {
		public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
		}
		public override uint? ClassCRC => 0xB6934339;
	}
}

