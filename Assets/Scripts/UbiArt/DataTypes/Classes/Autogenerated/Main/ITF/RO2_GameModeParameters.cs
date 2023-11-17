namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_GameModeParameters : GameModeParameters {
		public GameMode gameMode;
		public GameModeLegends gameModeLegends;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				gameModeLegends = s.Serialize<GameModeLegends>(gameModeLegends, name: "gameMode");
			} else {
				gameMode = s.Serialize<GameMode>(gameMode, name: "gameMode");
			}
		}
		public enum GameMode {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
		}
		public enum GameModeLegends {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_SHOOTER"   )] RO2_GAMEMODE_SHOOTER = 1,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 2,
		}
		public override uint? ClassCRC => 0xC1686E68;
	}
}

