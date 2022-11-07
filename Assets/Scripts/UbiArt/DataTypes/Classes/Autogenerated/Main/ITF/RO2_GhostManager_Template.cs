namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_GhostManager_Template : TemplateObj {
		public Path ghostPath;
		public CListO<RO2_GhostColor> config;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ghostPath = s.SerializeObject<Path>(ghostPath, name: "ghostPath");
			config = s.SerializeObject<CListO<RO2_GhostColor>>(config, name: "config");
		}
		public override uint? ClassCRC => 0x2F7CAAAD;
	}
}

