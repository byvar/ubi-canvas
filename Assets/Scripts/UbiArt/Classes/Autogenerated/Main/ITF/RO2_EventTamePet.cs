using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTamePet : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB5555530;
	}
}

