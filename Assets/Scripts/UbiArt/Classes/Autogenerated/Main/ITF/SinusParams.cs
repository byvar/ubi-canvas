using UnityEngine;

namespace UbiArt.ITF {
	public partial class SinusParams : BaseCurveParams {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEE9BD674;
	}
}

