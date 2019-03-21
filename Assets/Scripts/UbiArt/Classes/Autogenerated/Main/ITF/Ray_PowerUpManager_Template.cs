using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PowerUpManager_Template : CSerializable {
		[Serialize("uint__0")] public uint superPunchBasicMaxAmmo;
		[Serialize("uint__1")] public uint superPunchSeekingMaxAmmo;
		[Serialize("uint__2")] public uint swarmRepellerMaxAmmo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(superPunchBasicMaxAmmo));
			SerializeField(s, nameof(superPunchSeekingMaxAmmo));
			SerializeField(s, nameof(swarmRepellerMaxAmmo));
		}
	}
}

