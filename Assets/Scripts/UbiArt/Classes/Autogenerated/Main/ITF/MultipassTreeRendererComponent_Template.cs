using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		public CListO<BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				passes = s.SerializeObject<CListO<BezierBranchRendererPass_Template>>(passes, name: "passes");
			}
		}
		public override uint? ClassCRC => 0x4DC93411;
	}
}

