namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterSkillsConfig_Template : CSerializable {
		public StringID hasteBuffId;
		public StringID slowBuffId;
		public StringID paralyzeBuffId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasteBuffId = s.SerializeObject<StringID>(hasteBuffId, name: "hasteBuffId");
			slowBuffId = s.SerializeObject<StringID>(slowBuffId, name: "slowBuffId");
			paralyzeBuffId = s.SerializeObject<StringID>(paralyzeBuffId, name: "paralyzeBuffId");
		}
		public override uint? ClassCRC => 0x678C0EE0;
	}
}

