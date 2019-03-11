using UnityEngine;

namespace UbiArt.ITF {
	public partial class SolidPolylineComponent : PolylineComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5127E324;
	}
}

