using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventPowerUpCooldownReady : Event {
		[Serialize("id")] public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x47A87D96;
	}
}

