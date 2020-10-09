using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class Unknown_RL_3_sub_527D10 : CSerializable {
		public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<Placeholder>(input, name: "input");
		}
		public override uint? ClassCRC => 0x2DEC8742;
	}
}

