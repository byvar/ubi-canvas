using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuBasic_Template : UIItem_Template {
		[Serialize("validateItemSounds")] public Placeholder validateItemSounds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(validateItemSounds));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8C2AD444;
	}
}

