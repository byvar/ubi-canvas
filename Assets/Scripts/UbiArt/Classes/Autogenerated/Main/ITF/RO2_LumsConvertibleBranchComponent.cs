using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumsConvertibleBranchComponent : RO2_ConvertibleBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5386E9EB;
	}
}

