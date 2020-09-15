using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_242_sub_A3ABF0 : CSerializable {
		public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			state = s.Serialize<uint>(state, name: "state");
		}
		public override uint? ClassCRC => 0xCBA84A3E;
	}
}

