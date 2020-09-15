using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_32_sub_527D50 : CSerializable {
		public Placeholder input;
		public float frequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<Placeholder>(input, name: "input");
			frequency = s.Serialize<float>(frequency, name: "frequency");
		}
		public override uint? ClassCRC => 0xA28379D8;
	}
}

