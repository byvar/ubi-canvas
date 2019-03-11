using UnityEngine;

namespace UbiArt.ITF {
	public partial class ConvertibleBranchComponent : BezierBranchComponent {
		[Serialize("seed")] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(seed));
		}
		public override uint? ClassCRC => 0xAFC1D751;
	}
}

