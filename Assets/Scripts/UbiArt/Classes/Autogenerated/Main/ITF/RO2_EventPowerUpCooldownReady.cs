using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_EventPowerUpCooldownReady : Event {
		public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
		}
		public override uint? ClassCRC => 0x47A87D96;
	}
}

