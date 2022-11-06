using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIEventRequestGameOverMenuExit : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xCB6873AE;
	}
}

