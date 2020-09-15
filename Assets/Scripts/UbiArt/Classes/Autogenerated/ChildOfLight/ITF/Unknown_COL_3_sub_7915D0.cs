using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_3_sub_7915D0 : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0x72DE1623;
	}
}

