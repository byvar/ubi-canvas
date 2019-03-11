using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIUmbrellaBehavior_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("openAction"      )] public Placeholder openAction;
		[Serialize("closedAction"    )] public Placeholder closedAction;
		[Serialize("openingAction"   )] public Placeholder openingAction;
		[Serialize("closingAction"   )] public Placeholder closingAction;
		[Serialize("warningAction"   )] public Placeholder warningAction;
		[Serialize("closedStateTime" )] public float closedStateTime;
		[Serialize("warningStateTime")] public float warningStateTime;
		[Serialize("weightThreshold" )] public float weightThreshold;
		[Serialize("closeWithWeight" )] public bool closeWithWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openAction));
			SerializeField(s, nameof(closedAction));
			SerializeField(s, nameof(openingAction));
			SerializeField(s, nameof(closingAction));
			SerializeField(s, nameof(warningAction));
			SerializeField(s, nameof(closedStateTime));
			SerializeField(s, nameof(warningStateTime));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(closeWithWeight));
		}
		public override uint? ClassCRC => 0x59A2B301;
	}
}

