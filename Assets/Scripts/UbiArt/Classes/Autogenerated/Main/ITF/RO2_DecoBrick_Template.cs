using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DecoBrick_Template : RO2_EnduranceBrick_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x22A165CF;
	}
}

