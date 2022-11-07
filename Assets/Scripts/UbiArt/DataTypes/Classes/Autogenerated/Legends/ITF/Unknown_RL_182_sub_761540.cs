namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_182_sub_761540 : Unknown_RL_219_sub_A763E0 {
		public string name;
		public PathRef mapPath;
		public int hasOnlineContent;
		public int needFocusToActivate;
		public LocalisationId highlightText;
		public Path highlightIcon;
		public Vec3d highlightOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				name = s.Serialize<string>(name, name: "name");
				mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
				hasOnlineContent = s.Serialize<int>(hasOnlineContent, name: "hasOnlineContent");
				needFocusToActivate = s.Serialize<int>(needFocusToActivate, name: "needFocusToActivate");
				highlightText = s.SerializeObject<LocalisationId>(highlightText, name: "highlightText");
				highlightIcon = s.SerializeObject<Path>(highlightIcon, name: "highlightIcon");
				highlightOffset = s.SerializeObject<Vec3d>(highlightOffset, name: "highlightOffset");
			}
		}
		public override uint? ClassCRC => 0x5732E6D6;
	}
}

