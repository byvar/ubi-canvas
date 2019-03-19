using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GhostManager_Template : TemplateObj {
		[Serialize("ghostPath")] public Path ghostPath;
		[Serialize("config"   )] public CList<RO2_GhostColor> config;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ghostPath));
			SerializeField(s, nameof(config));
		}
		public override uint? ClassCRC => 0x2F7CAAAD;
	}
}

