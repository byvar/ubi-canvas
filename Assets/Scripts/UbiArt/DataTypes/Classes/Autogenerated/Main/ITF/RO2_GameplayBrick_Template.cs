namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_GameplayBrick_Template : RO2_EnduranceBrick_Template {
		public CListO<StringID> ruleTags;
		public StringID decoBrick;
		public StringID decoBrickFlipped;
		public bool isGapOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ruleTags = s.SerializeObject<CListO<StringID>>(ruleTags, name: "ruleTags");
			decoBrick = s.SerializeObject<StringID>(decoBrick, name: "decoBrick");
			decoBrickFlipped = s.SerializeObject<StringID>(decoBrickFlipped, name: "decoBrickFlipped");
			isGapOnly = s.Serialize<bool>(isGapOnly, name: "isGapOnly");
		}
		public override uint? ClassCRC => 0x0FB4A8DA;
	}
}

