using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierTreeComponent_Template : RO2_BezierTree_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x23D04434;
	}
}

