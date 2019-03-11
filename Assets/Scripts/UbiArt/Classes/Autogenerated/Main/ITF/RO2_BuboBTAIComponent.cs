using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BuboBTAIComponent : BTAIComponent {
		[Serialize("crushable"       )] public bool crushable;
		[Serialize("triggerActivator")] public bool triggerActivator;
		[Serialize("delayTrigger"    )] public bool delayTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(crushable));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(delayTrigger));
			}
		}
		public override uint? ClassCRC => 0x80FD5DF4;
	}
}

