using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class Trail3DComponent_Template : GraphicComponent_Template {
		public CListO<Trail_Template> trailList;
		public bool startActive;
		public bool draw2D;
		public bool fixDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				trailList = s.SerializeObject<CListO<Trail_Template>>(trailList, name: "trailList");
				startActive = s.Serialize<bool>(startActive, name: "startActive");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
			} else if (Settings.s.game == Settings.Game.COL) {
				startActive = s.Serialize<bool>(startActive, name: "startActive");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
				fixDepth = s.Serialize<bool>(fixDepth, name: "fixDepth");
			} else {
				trailList = s.SerializeObject<CListO<Trail_Template>>(trailList, name: "trailList");
				startActive = s.Serialize<bool>(startActive, name: "startActive");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
				fixDepth = s.Serialize<bool>(fixDepth, name: "fixDepth");
			}
		}
		public override uint? ClassCRC => 0xC58BDE47;
	}
}

