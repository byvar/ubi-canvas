namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SceneSettingsComponent_Template : CSerializable {
		public uint maxPlayers;
		public int allowFriendlyFire;
		public int allowPlayerCrush;
		public int allowNpcCrush;
		public int invincibleEnemies;
		public int enableCheatMode;
		public int powerupDive;
		public int powerupWalkOnWalls;
		public int powerupReduction;
		public int powerupHelicopter;
		public int powerupFight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxPlayers = s.Serialize<uint>(maxPlayers, name: "maxPlayers");
			allowFriendlyFire = s.Serialize<int>(allowFriendlyFire, name: "allowFriendlyFire");
			allowPlayerCrush = s.Serialize<int>(allowPlayerCrush, name: "allowPlayerCrush");
			allowNpcCrush = s.Serialize<int>(allowNpcCrush, name: "allowNpcCrush");
			invincibleEnemies = s.Serialize<int>(invincibleEnemies, name: "invincibleEnemies");
			enableCheatMode = s.Serialize<int>(enableCheatMode, name: "enableCheatMode");
			powerupDive = s.Serialize<int>(powerupDive, name: "powerupDive");
			powerupWalkOnWalls = s.Serialize<int>(powerupWalkOnWalls, name: "powerupWalkOnWalls");
			powerupReduction = s.Serialize<int>(powerupReduction, name: "powerupReduction");
			powerupHelicopter = s.Serialize<int>(powerupHelicopter, name: "powerupHelicopter");
			powerupFight = s.Serialize<int>(powerupFight, name: "powerupFight");
		}
		public override uint? ClassCRC => 0x6C70138C;
	}
}

