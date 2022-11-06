using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuItemText : UIComponent {
		public LocalisationId lineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lineId = s.SerializeObject<LocalisationId>(lineId, name: "lineId");
		}
		public override uint? ClassCRC => 0xC21120FD;
	}
}

