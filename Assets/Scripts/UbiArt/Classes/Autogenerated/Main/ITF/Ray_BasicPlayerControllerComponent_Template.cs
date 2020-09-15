using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BasicPlayerControllerComponent_Template : PlayerControllerComponent_Template {
		public CList<LumDrop_Template> deathLumDropTemplateList;
		public Path deathLumPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			deathLumDropTemplateList = s.SerializeObject<CList<LumDrop_Template>>(deathLumDropTemplateList, name: "deathLumDropTemplateList");
			deathLumPath = s.SerializeObject<Path>(deathLumPath, name: "deathLumPath");
		}
		public override uint? ClassCRC => 0xDB53DCEA;
	}
}

