using System;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class GamesAttribute : Attribute {

		private GameFlags flags;
		private PlatformFlags platforms;

		public GamesAttribute(GameFlags flags, PlatformFlags platforms = PlatformFlags.All) {
			this.flags = flags;
			this.platforms = platforms;
		}

		public bool HasFlag(GameFlags flag) => flags.HasFlag(flag);
		public bool HasPlatform(PlatformFlags flag) => platforms.HasFlag(flag);

		public bool HasGame(Settings.Game game) {
			return game switch {
				Settings.Game.RO =>  HasFlag(GameFlags.RO),
				Settings.Game.RJR => HasFlag(GameFlags.RJR),
				Settings.Game.RFR => HasFlag(GameFlags.RFR),
				Settings.Game.RL =>  HasFlag(GameFlags.RL),
				Settings.Game.RA =>  HasFlag(GameFlags.RA),
				Settings.Game.RM =>  HasFlag(GameFlags.RM),
				Settings.Game.VH =>  HasFlag(GameFlags.VH),
				Settings.Game.COL => HasFlag(GameFlags.COL),
				_ => false
			};
		}
		public bool HasPlatform(Settings.Platform platform) {
			return platform switch {
				Settings.Platform.PC => HasPlatform(PlatformFlags.PC),
				Settings.Platform.Android => HasPlatform(PlatformFlags.Android),
				Settings.Platform.iOS => HasPlatform(PlatformFlags.iOS),
				Settings.Platform.MacOS => HasPlatform(PlatformFlags.MacOS),
				Settings.Platform.Vita => HasPlatform(PlatformFlags.Vita),
				Settings.Platform.WiiU => HasPlatform(PlatformFlags.WiiU),
				_ => false
			};;
		}
	}
}