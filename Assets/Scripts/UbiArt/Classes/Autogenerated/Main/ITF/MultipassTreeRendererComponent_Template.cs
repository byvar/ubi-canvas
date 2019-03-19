using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("passes")] public CList<BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(passes));
			}
		}
		public override uint? ClassCRC => 0x4DC93411;
	}
}

