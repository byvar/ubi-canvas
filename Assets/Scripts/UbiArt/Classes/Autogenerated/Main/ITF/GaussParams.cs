using UnityEngine;

namespace UbiArt.ITF {
	public partial class GaussParams : BaseCurveParams {
		[Serialize("curveHeight")] public float curveHeight;
		[Serialize("bellCenter" )] public float bellCenter;
		[Serialize("bellWidth"  )] public float bellWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(curveHeight));
			SerializeField(s, nameof(bellCenter));
			SerializeField(s, nameof(bellWidth));
		}
		public override uint? ClassCRC => 0x325E2106;
	}
}

