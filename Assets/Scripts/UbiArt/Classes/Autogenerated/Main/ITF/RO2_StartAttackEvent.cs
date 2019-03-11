using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StartAttackEvent : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC8BC334D;
	}
}

