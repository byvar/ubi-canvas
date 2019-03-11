using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EndAttackEvent : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1612146E;
	}
}

