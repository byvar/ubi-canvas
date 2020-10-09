using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class Unknown_RL_66_sub_943D80 : CSerializable {
		public Placeholder leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leafs = s.SerializeObject<Placeholder>(leafs, name: "leafs");
		}
		public override uint? ClassCRC => 0x7B7FC5BA;
	}
}

