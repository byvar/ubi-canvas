using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FairyComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x193F5DC1;
	}
}

