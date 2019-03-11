using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhantomDetectorComponent : ShapeDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8ADEC12A;
	}
}

