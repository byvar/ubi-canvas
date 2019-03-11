using UnityEngine;

namespace UbiArt.ITF {
	public partial class RotatingPolylineComponent : PolylineComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFB5EA5D5;
	}
}

