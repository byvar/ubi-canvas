using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchFxComponent_Template : BezierBranchComponent_Template {
		[Serialize("fxStart"  )] public StringID fxStart;
		[Serialize("fxLoop"   )] public StringID fxLoop;
		[Serialize("fxStop"   )] public StringID fxStop;
		[Serialize("fxDefault")] public StringID fxDefault;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxStart));
			SerializeField(s, nameof(fxLoop));
			SerializeField(s, nameof(fxStop));
			SerializeField(s, nameof(fxDefault));
		}
		public override uint? ClassCRC => 0xD2C2C0CB;
	}
}

