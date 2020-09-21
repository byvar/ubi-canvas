using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FontEffectList_Template : TemplateObj {
		public CListO<FontEffect_Template> effects;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				effects = s.SerializeObject<CListO<FontEffect_Template>>(effects, name: "effects");
			}
		}
		public override uint? ClassCRC => 0x5261948B;
	}
}

