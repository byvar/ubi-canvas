using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackControllerComponent_Template : CSerializable {
		public StringID feedbackContextTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			feedbackContextTag = s.SerializeObject<StringID>(feedbackContextTag, name: "feedbackContextTag");
		}
		public override uint? ClassCRC => 0x1503FC8C;
	}
}

