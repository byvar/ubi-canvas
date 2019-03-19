using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuSoundComponent_Template : ActorComponent_Template {
		[Serialize("pageConfigList")] public CList<UIMenuPageSoundConfig> pageConfigList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(pageConfigList));
			}
		}
		public override uint? ClassCRC => 0x1C3ACDE0;
	}
}

