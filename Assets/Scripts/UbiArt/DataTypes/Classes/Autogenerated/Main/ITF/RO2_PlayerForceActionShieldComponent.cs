namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlayerForceActionShieldComponent : RO2_PlayerForceActionComponent {
		public bool testShieldInZone;
		public bool removeShieldCollision;
		public bool testPlayerOnShield;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					testShieldInZone = s.Serialize<bool>(testShieldInZone, name: "testShieldInZone", options: CSerializerObject.Options.BoolAsByte);
					removeShieldCollision = s.Serialize<bool>(removeShieldCollision, name: "removeShieldCollision", options: CSerializerObject.Options.BoolAsByte);
					testPlayerOnShield = s.Serialize<bool>(testPlayerOnShield, name: "testPlayerOnShield", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					testShieldInZone = s.Serialize<bool>(testShieldInZone, name: "testShieldInZone");
					removeShieldCollision = s.Serialize<bool>(removeShieldCollision, name: "removeShieldCollision");
					testPlayerOnShield = s.Serialize<bool>(testPlayerOnShield, name: "testPlayerOnShield");
				}
			}
		}
		public override uint? ClassCRC => 0x94435009;
	}
}

