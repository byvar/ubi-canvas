using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionUmbrella_Template : BTAction_Template {
		[Serialize("animationOpen"   )] public StringID animationOpen;
		[Serialize("animationClosed" )] public StringID animationClosed;
		[Serialize("animationOpening")] public StringID animationOpening;
		[Serialize("animationClosing")] public StringID animationClosing;
		[Serialize("animationWarning")] public StringID animationWarning;
		[Serialize("closeWithWeight" )] public bool closeWithWeight;
		[Serialize("weightThreshold" )] public float weightThreshold;
		[Serialize("closedStateTime" )] public float closedStateTime;
		[Serialize("warningStateTime")] public float warningStateTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animationOpen));
			SerializeField(s, nameof(animationClosed));
			SerializeField(s, nameof(animationOpening));
			SerializeField(s, nameof(animationClosing));
			SerializeField(s, nameof(animationWarning));
			SerializeField(s, nameof(closeWithWeight));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(closedStateTime));
			SerializeField(s, nameof(warningStateTime));
		}
		public override uint? ClassCRC => 0xC8C29C97;
	}
}

