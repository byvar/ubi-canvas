using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_BonusLevelSpotComponent_Template : Ray_WM_LevelSpotComponent_Template {
		[Serialize("bubblePath"  )] public Path bubblePath;
		[Serialize("panelAct"    )] public Path panelAct;
		[Serialize("panelBone"   )] public StringID panelBone;
		[Serialize("panelOffset" )] public Vec3d panelOffset;
		[Serialize("blockedLines")] public Placeholder blockedLines;
		[Serialize("openLines"   )] public Placeholder openLines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(panelAct));
			SerializeField(s, nameof(panelBone));
			SerializeField(s, nameof(panelOffset));
			SerializeField(s, nameof(blockedLines));
			SerializeField(s, nameof(openLines));
		}
		public override uint? ClassCRC => 0x3B5119F4;
	}
}

