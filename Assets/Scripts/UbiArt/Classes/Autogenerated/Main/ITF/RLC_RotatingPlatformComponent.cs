using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RotatingPlatformComponent : ActorComponent {
		[Serialize("clockwiseRotationLocked"       )] public bool clockwiseRotationLocked;
		[Serialize("counterClockwiseRotationLocked")] public bool counterClockwiseRotationLocked;
		[Serialize("playerActivationOnly"          )] public bool playerActivationOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(clockwiseRotationLocked));
			SerializeField(s, nameof(counterClockwiseRotationLocked));
			SerializeField(s, nameof(playerActivationOnly));
		}
		public override uint? ClassCRC => 0xEB17959E;
	}
}

