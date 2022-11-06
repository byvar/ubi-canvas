using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStartCinematicDialog : Event {
		public Placeholder data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			data = s.SerializeObject<Placeholder>(data, name: "data");
		}
		public override uint? ClassCRC => 0x533E6688;
	}
}

