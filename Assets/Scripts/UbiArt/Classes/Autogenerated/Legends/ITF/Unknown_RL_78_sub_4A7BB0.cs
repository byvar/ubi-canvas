using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_78_sub_4A7BB0 : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xB87B76E3;
	}
}

