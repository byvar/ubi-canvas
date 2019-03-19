using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchFxComponent_Template : RO2_BezierBranchComponent_Template {
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
		public override uint? ClassCRC => 0x434D51D8;
	}
}

