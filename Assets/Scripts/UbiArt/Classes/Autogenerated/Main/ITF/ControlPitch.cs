using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class ControlPitch : SoundModifier {
		public ProceduralInputData input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<ProceduralInputData>(input, name: "input");
		}
		public override uint? ClassCRC => 0x9BBD8C4E;
	}
}

