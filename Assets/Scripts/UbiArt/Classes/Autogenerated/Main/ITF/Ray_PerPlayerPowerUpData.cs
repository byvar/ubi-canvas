using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PerPlayerPowerUpData : CSerializable {
		public bool enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enabled = s.Serialize<bool>(enabled, name: "enabled");
		}
	}
}

