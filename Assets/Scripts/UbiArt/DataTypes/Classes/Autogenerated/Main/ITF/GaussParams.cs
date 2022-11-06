using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class GaussParams : BaseCurveParams {
		public float curveHeight;
		public float bellCenter;
		public float bellWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			curveHeight = s.Serialize<float>(curveHeight, name: "curveHeight");
			bellCenter = s.Serialize<float>(bellCenter, name: "bellCenter");
			bellWidth = s.Serialize<float>(bellWidth, name: "bellWidth");
		}
		public override uint? ClassCRC => 0x325E2106;
	}
}

