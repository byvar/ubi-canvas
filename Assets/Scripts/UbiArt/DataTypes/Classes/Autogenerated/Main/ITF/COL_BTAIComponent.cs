namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTAIComponent : BTAIComponent {
		public Generic<COL_NPCAIData> npcAIDatas;
		public StringID defaultFeedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				npcAIDatas = s.SerializeObject<Generic<COL_NPCAIData>>(npcAIDatas, name: "npcAIDatas");
				defaultFeedbackID = s.SerializeObject<StringID>(defaultFeedbackID, name: "defaultFeedbackID");
			}
		}
		public override uint? ClassCRC => 0x0E95F48C;
	}
}

