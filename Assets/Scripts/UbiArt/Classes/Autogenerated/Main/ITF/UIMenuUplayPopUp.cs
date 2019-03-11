using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuUplayPopUp : UIMenu {
		[Serialize("defaultItem")] public StringID defaultItem;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(defaultItem));
			}
		}
		public override uint? ClassCRC => 0x36C8ACDE;
	}
}

