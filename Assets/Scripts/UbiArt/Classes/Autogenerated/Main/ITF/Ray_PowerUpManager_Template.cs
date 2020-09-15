using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PowerUpManager_Template : CSerializable {
		public uint superPunchBasicMaxAmmo;
		public uint superPunchSeekingMaxAmmo;
		public uint swarmRepellerMaxAmmo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			superPunchBasicMaxAmmo = s.Serialize<uint>(superPunchBasicMaxAmmo, name: "superPunchBasicMaxAmmo");
			superPunchSeekingMaxAmmo = s.Serialize<uint>(superPunchSeekingMaxAmmo, name: "superPunchSeekingMaxAmmo");
			swarmRepellerMaxAmmo = s.Serialize<uint>(swarmRepellerMaxAmmo, name: "swarmRepellerMaxAmmo");
		}
	}
}

