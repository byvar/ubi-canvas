using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuItemText : CSerializable {
		[Serialize("lineId")] public LocalisationId lineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lineId));
		}
		public override uint? ClassCRC => 0xC21120FD;
	}
}

