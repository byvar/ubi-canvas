using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class UICheckBoxComponent : UIItem {
		public StringID checkBoxCheckedID;
		public StringID checkBoxUncheckedID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
			} else {
				checkBoxCheckedID = s.SerializeObject<StringID>(checkBoxCheckedID, name: "checkBoxCheckedID");
				checkBoxUncheckedID = s.SerializeObject<StringID>(checkBoxUncheckedID, name: "checkBoxUncheckedID");
			}
		}
		public override uint? ClassCRC => 0x4CEFD4BA;
	}
}

