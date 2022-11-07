namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class SkillRatingConfig_Template : ITF.TemplateObj {
		public uint DefaultSkillboard;
		public bool AutoFetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DefaultSkillboard = s.Serialize<uint>(DefaultSkillboard, name: "DefaultSkillboard");
			AutoFetch = s.Serialize<bool>(AutoFetch, name: "AutoFetch");
		}
		public override uint? ClassCRC => 0xC133B853;
	}
}

