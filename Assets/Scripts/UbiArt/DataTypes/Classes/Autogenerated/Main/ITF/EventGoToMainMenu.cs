using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventGoToMainMenu : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x40CBBAA6;
	}
}

