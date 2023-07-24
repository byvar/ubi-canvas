namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteractiveComponent_Template : ActorComponent_Template {
		public float interactButtonYOffset;
		public float interactButtonZOffsetFromAurora;
		public Placeholder authorizedPCStates;
		public StringID onInteractFeedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interactButtonYOffset = s.Serialize<float>(interactButtonYOffset, name: "interactButtonYOffset");
			interactButtonZOffsetFromAurora = s.Serialize<float>(interactButtonZOffsetFromAurora, name: "interactButtonZOffsetFromAurora");
			authorizedPCStates = s.SerializeObject<Placeholder>(authorizedPCStates, name: "authorizedPCStates");
			onInteractFeedbackID = s.SerializeObject<StringID>(onInteractFeedbackID, name: "onInteractFeedbackID");
		}
		public override uint? ClassCRC => 0x97819D56;
	}
}

