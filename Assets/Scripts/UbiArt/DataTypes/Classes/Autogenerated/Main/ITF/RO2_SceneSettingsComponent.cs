namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SceneSettingsComponent : ActorComponent {
		public RO2_GlobalPowerUpUnlocked unlockedPowerUps;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				unlockedPowerUps = s.SerializeObject<RO2_GlobalPowerUpUnlocked>(unlockedPowerUps, name: "unlockedPowerUps");
			}
		}
		public override uint? ClassCRC => 0xBE78973C;
	}
}

