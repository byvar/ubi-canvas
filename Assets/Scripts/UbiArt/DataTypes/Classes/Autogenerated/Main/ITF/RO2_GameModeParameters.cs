namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_GameModeParameters : GameModeParameters {
		public GameMode gameMode;
		public GameMode2 gameMode2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				gameMode2 = s.Serialize<GameMode2>(gameMode2, name: "gameMode");
			} else {
				gameMode = s.Serialize<GameMode>(gameMode, name: "gameMode");
			}
		}
		public enum GameMode {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
		}
		public enum GameMode2 {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
			[Serialize("RO2_GAMEMODE_2"         )] RO2_GAMEMODE_2 = 2,
		}
		public override uint? ClassCRC => 0xC1686E68;
	}
}

