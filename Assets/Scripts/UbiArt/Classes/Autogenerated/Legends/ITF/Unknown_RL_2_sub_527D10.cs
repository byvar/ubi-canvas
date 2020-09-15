using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_2_sub_527D10 : SoundModifier {
		public ProceduralInputData input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<ProceduralInputData>(input, name: "input");
		}
		public override uint? ClassCRC => 0x42FD73DC;
	}
}

