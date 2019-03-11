using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchEyeTriggerComponent : ShapeComponent {
		[Serialize("startOpen"               )] public bool startOpen;
		[Serialize("openDuration"            )] public float openDuration;
		[Serialize("closedDuration"          )] public float closedDuration;
		[Serialize("sendTapAlways"           )] public bool sendTapAlways;
		[Serialize("invertSentOpenCloseEvent")] public bool invertSentOpenCloseEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(openDuration));
				SerializeField(s, nameof(closedDuration));
				SerializeField(s, nameof(sendTapAlways));
				SerializeField(s, nameof(invertSentOpenCloseEvent));
			}
		}
		public override uint? ClassCRC => 0x59D67286;
	}
}

