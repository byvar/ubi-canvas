using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GeyserComponent : RO2_ChildLaunchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAF65674A;
	}
}

