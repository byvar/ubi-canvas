using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_StringWaveGeneratorComponent : ActorComponent {
		public bool startsActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startsActivated = s.Serialize<bool>(startsActivated, name: "startsActivated");
			}
		}
		public override uint? ClassCRC => 0x2F55D408;
	}
}

