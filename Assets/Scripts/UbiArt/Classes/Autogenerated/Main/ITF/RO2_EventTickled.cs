using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTickled : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x84C82669;
	}
}

