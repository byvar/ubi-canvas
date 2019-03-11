using UnityEngine;

namespace UbiArt.ITF {
	public partial class ExpParams : BaseCurveParams {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCF73C204;
	}
}

