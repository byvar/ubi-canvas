using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysShapeMovingPolyline : PhysShapePolyline {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1277923C;
	}
}

