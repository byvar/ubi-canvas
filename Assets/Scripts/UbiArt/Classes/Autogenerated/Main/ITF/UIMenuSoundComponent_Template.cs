using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuSoundComponent_Template : ActorComponent_Template {
		public CList<UIMenuPageSoundConfig> pageConfigList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				pageConfigList = s.SerializeObject<CList<UIMenuPageSoundConfig>>(pageConfigList, name: "pageConfigList");
			}
		}
		public override uint? ClassCRC => 0x1C3ACDE0;
	}
}

