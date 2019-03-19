using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerForceActionShieldComponent : RO2_PlayerForceActionComponent {
		[Serialize("testShieldInZone"     )] public bool testShieldInZone;
		[Serialize("removeShieldCollision")] public bool removeShieldCollision;
		[Serialize("testPlayerOnShield"   )] public bool testPlayerOnShield;
		[Serialize("testPlayerOnShield"   )] public byte testPlayerOnShield;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(testShieldInZone), boolAsByte: true);
					SerializeField(s, nameof(removeShieldCollision), boolAsByte: true);
					SerializeField(s, nameof(testPlayerOnShield));
				}
				SerializeField(s, nameof(testPlayerOnShield));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(testShieldInZone));
					SerializeField(s, nameof(removeShieldCollision));
					SerializeField(s, nameof(testPlayerOnShield));
				}
			}
		}
		public override uint? ClassCRC => 0x94435009;
	}
}

