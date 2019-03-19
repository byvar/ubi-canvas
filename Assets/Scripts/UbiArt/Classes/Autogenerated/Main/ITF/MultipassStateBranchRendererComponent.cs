using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MultipassStateBranchRendererComponent : BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
		}
		public override uint? ClassCRC => 0x4ECEFE3B;
	}
}

