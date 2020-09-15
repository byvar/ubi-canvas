using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MurphyFingerComponent : ActorComponent {
		public bool left;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				left = s.Serialize<bool>(left, name: "left");
			}
		}
		public override uint? ClassCRC => 0x7681486C;
	}
}

