using UnityEngine;

namespace UbiArt.ITF {
	public partial class AxisPolylineComponent : PolylineComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3BD75017;
	}
}

