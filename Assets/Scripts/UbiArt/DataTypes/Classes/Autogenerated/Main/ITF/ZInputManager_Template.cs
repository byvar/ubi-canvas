namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class ZInputManager_Template : TemplateObj {
		public StringID name;
		public StringID config;
		public uint category;
		public CListO<ZAction> actions;
		public StringID mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				config = s.SerializeObject<StringID>(config, name: "config");
				mode = s.SerializeObject<StringID>(mode, name: "mode");
				category = s.Serialize<uint>(category, name: "category");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				config = s.SerializeObject<StringID>(config, name: "config");
				category = s.Serialize<uint>(category, name: "category");
				actions = s.SerializeObject<CListO<ZAction>>(actions, name: "actions");
			}
		}
		public override uint? ClassCRC => 0xD63A5C7E;
	}
}

