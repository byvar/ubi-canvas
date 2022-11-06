using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIMenuUplayPopUp : UIMenu {
		public StringID defaultItem;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultItem = s.SerializeObject<StringID>(defaultItem, name: "defaultItem");
			}
		}
		public override uint? ClassCRC => 0x36C8ACDE;
	}
}

