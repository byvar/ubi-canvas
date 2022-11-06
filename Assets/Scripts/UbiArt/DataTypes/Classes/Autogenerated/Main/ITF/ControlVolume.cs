using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class ControlVolume : SoundModifier {
		public ProceduralInputData input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<ProceduralInputData>(input, name: "input");
		}
		public override uint? ClassCRC => 0xD06EA098;
	}
}

