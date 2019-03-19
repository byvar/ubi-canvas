using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FontEffectList_Template : TemplateObj {
		[Serialize("effects")] public CList<FontEffect_Template> effects;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(effects));
			}
		}
		public override uint? ClassCRC => 0x5261948B;
	}
}

