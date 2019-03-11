using UnityEngine;

namespace UbiArt.ITF {
	public partial class BounceOnPolylinePhysComponent : PhysComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8106BEF6;
	}
}

