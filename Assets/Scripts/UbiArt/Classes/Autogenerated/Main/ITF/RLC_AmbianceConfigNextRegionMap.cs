using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceConfigNextRegionMap : RLC_AmbianceConfig {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x07451332;
	}
}

