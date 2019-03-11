using UnityEngine;

namespace UbiArt.ITF {
	public partial class PackageDescriptor_Template : TemplateObj {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE155D900;
	}
}

