namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SkillTreeUIItem : CSerializable {
		[Description("Skill's StringID.")]
		public StringID skillID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			skillID = s.SerializeObject<StringID>(skillID, name: "skillID");
		}
		public override uint? ClassCRC => 0x2A19D588;
	}
}

