namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStopFeedback : Event {
		public StringID feedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			feedbackID = s.SerializeObject<StringID>(feedbackID, name: "feedbackID");
		}
		public override uint? ClassCRC => 0x9BC03EF5;
	}
}

