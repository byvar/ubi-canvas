using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionUmbrella_Template : BTAction_Template {
		public StringID animationOpen;
		public StringID animationClosed;
		public StringID animationOpening;
		public StringID animationClosing;
		public StringID animationWarning;
		public bool closeWithWeight;
		public float weightThreshold;
		public float closedStateTime;
		public float warningStateTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animationOpen = s.SerializeObject<StringID>(animationOpen, name: "animationOpen");
			animationClosed = s.SerializeObject<StringID>(animationClosed, name: "animationClosed");
			animationOpening = s.SerializeObject<StringID>(animationOpening, name: "animationOpening");
			animationClosing = s.SerializeObject<StringID>(animationClosing, name: "animationClosing");
			animationWarning = s.SerializeObject<StringID>(animationWarning, name: "animationWarning");
			closeWithWeight = s.Serialize<bool>(closeWithWeight, name: "closeWithWeight");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			closedStateTime = s.Serialize<float>(closedStateTime, name: "closedStateTime");
			warningStateTime = s.Serialize<float>(warningStateTime, name: "warningStateTime");
		}
		public override uint? ClassCRC => 0xC8C29C97;
	}
}

