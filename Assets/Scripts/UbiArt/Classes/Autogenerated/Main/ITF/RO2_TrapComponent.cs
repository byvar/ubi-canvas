using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrapComponent : ActorComponent {
		public bool isTrapped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isTrapped = s.Serialize<bool>(isTrapped, name: "isTrapped");
		}
		public override uint? ClassCRC => 0xBC91C26F;
	}
}

