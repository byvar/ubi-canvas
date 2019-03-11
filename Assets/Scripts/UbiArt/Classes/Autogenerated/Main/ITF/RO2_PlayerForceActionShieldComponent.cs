using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlayerForceActionShieldComponent : RO2_PlayerForceActionComponent {
		[Serialize("testShieldInZone"     )] public bool testShieldInZone;
		[Serialize("removeShieldCollision")] public bool removeShieldCollision;
		[Serialize("testPlayerOnShield"   )] public bool testPlayerOnShield;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(testShieldInZone));
				SerializeField(s, nameof(removeShieldCollision));
				SerializeField(s, nameof(testPlayerOnShield));
			}
		}
		public override uint? ClassCRC => 0x94435009;
	}
}

