namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackControllerComponent : FXControllerComponent {
		public StringID feedbackContextTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			feedbackContextTag = s.SerializeObject<StringID>(feedbackContextTag, name: "feedbackContextTag");
		}
		public override uint? ClassCRC => 0x70E0D7AD;
	}
}

