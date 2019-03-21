using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStopFeedback : Event {
		[Serialize("feedbackID")] public StringID feedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(feedbackID));
		}
		public override uint? ClassCRC => 0xC2D4F68A;
	}
}

