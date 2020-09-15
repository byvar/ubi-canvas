using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class Doppler : SoundModifier {
		public float factor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factor = s.Serialize<float>(factor, name: "factor");
		}
		public override uint? ClassCRC => 0xF0C59556;
	}
}

