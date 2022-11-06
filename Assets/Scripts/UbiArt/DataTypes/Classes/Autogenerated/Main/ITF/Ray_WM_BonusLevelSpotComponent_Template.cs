using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_BonusLevelSpotComponent_Template : Ray_WM_LevelSpotComponent_Template {
		public Path bubblePath;
		public Path panelAct;
		public StringID panelBone;
		public Vec3d panelOffset;
		public Placeholder blockedLines;
		public Placeholder openLines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			panelAct = s.SerializeObject<Path>(panelAct, name: "panelAct");
			panelBone = s.SerializeObject<StringID>(panelBone, name: "panelBone");
			panelOffset = s.SerializeObject<Vec3d>(panelOffset, name: "panelOffset");
			blockedLines = s.SerializeObject<Placeholder>(blockedLines, name: "blockedLines");
			openLines = s.SerializeObject<Placeholder>(openLines, name: "openLines");
		}
		public override uint? ClassCRC => 0x3B5119F4;
	}
}

