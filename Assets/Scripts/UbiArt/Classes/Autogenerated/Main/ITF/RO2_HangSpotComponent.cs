using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HangSpotComponent : ActorComponent {
		public bool keepOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			keepOrientation = s.Serialize<bool>(keepOrientation, name: "keepOrientation");
		}
		public override uint? ClassCRC => 0x5941DEB5;
	}
}

