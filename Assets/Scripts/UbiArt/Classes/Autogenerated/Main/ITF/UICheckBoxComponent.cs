using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class UICheckBoxComponent : UIItem {
		[Serialize("checkBoxCheckedID"  )] public StringID checkBoxCheckedID;
		[Serialize("checkBoxUncheckedID")] public StringID checkBoxUncheckedID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(checkBoxCheckedID));
				SerializeField(s, nameof(checkBoxUncheckedID));
			}
		}
		public override uint? ClassCRC => 0x4CEFD4BA;
	}
}

