using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GhostManager_Template : TemplateObj {
		public Path ghostPath;
		public CList<RO2_GhostColor> config;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ghostPath = s.SerializeObject<Path>(ghostPath, name: "ghostPath");
			config = s.SerializeObject<CList<RO2_GhostColor>>(config, name: "config");
		}
		public override uint? ClassCRC => 0x2F7CAAAD;
	}
}

