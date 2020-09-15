using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RotatingPlatformComponent : ActorComponent {
		public bool clockwiseRotationLocked;
		public bool counterClockwiseRotationLocked;
		public bool playerActivationOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			clockwiseRotationLocked = s.Serialize<bool>(clockwiseRotationLocked, name: "clockwiseRotationLocked");
			counterClockwiseRotationLocked = s.Serialize<bool>(counterClockwiseRotationLocked, name: "counterClockwiseRotationLocked");
			playerActivationOnly = s.Serialize<bool>(playerActivationOnly, name: "playerActivationOnly");
		}
		public override uint? ClassCRC => 0xEB17959E;
	}
}

