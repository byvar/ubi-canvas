using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackControllerComponent_Template : CSerializable {
		[Serialize("feedbackContextTag")] public StringID feedbackContextTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(feedbackContextTag));
		}
		public override uint? ClassCRC => 0x2C1FFDED;
	}
}

