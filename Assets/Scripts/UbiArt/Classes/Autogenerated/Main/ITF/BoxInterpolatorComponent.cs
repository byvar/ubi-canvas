using UnityEngine;

namespace UbiArt.ITF {
	public partial class BoxInterpolatorComponent : InterpolatorComponent {
		[Serialize("innerBox")] public AABB innerBox;
		[Serialize("outerBox")] public AABB outerBox;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(innerBox));
				SerializeField(s, nameof(outerBox));
			}
		}
		public override uint? ClassCRC => 0xF51360DA;
	}
}

