using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TextBoxComponent_Template : UIComponent_Template {
		public CList<FontTextArea.Style> styles;
		public float depthOffset;
		public CList<Path> preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				styles = s.SerializeObject<CList<FontTextArea.Style>>(styles, name: "styles");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				preSpawnedActorPaths = s.SerializeObject<CList<Path>>(preSpawnedActorPaths, name: "preSpawnedActorPaths");
			} else {
				styles = s.SerializeObject<CList<FontTextArea.Style>>(styles, name: "styles");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			}
		}
		public override uint? ClassCRC => 0x657ACC79;
	}
}

