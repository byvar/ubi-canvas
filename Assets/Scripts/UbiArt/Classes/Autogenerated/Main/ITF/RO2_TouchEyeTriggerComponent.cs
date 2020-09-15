using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchEyeTriggerComponent : ShapeComponent {
		public bool startOpen;
		public float openDuration;
		public float closedDuration;
		public bool sendTapAlways;
		public bool invertSentOpenCloseEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					startOpen = s.Serialize<bool>(startOpen, name: "startOpen", options: CSerializerObject.Options.BoolAsByte);
					openDuration = s.Serialize<float>(openDuration, name: "openDuration");
					closedDuration = s.Serialize<float>(closedDuration, name: "closedDuration");
					sendTapAlways = s.Serialize<bool>(sendTapAlways, name: "sendTapAlways");
					invertSentOpenCloseEvent = s.Serialize<bool>(invertSentOpenCloseEvent, name: "invertSentOpenCloseEvent", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					startOpen = s.Serialize<bool>(startOpen, name: "startOpen");
					openDuration = s.Serialize<float>(openDuration, name: "openDuration");
					closedDuration = s.Serialize<float>(closedDuration, name: "closedDuration");
					sendTapAlways = s.Serialize<bool>(sendTapAlways, name: "sendTapAlways");
					invertSentOpenCloseEvent = s.Serialize<bool>(invertSentOpenCloseEvent, name: "invertSentOpenCloseEvent");
				}
			}
		}
		public override uint? ClassCRC => 0x59D67286;
	}
}

