using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LuckyTicketComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9D1A7261;
	}
}

