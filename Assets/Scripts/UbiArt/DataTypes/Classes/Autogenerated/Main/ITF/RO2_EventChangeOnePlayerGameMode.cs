namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventChangeOnePlayerGameMode : Event {
		public GameMode mode;
		public GameModeLegends modeLegends;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				modeLegends = s.Serialize<GameModeLegends>(modeLegends, name: "mode");
			} else {
				mode = s.Serialize<GameMode>(mode, name: "mode");
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
		public override uint? ClassCRC => 0x7D2C2EB4;
	}
}

