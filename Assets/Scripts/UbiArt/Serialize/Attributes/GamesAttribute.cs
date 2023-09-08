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

		public bool HasGame(Game game) {
			return game switch {
				Game.RO =>  HasFlag(GameFlags.RO),
				Game.RJR => HasFlag(GameFlags.RJR),
				Game.RFR => HasFlag(GameFlags.RFR),
				Game.RL =>  HasFlag(GameFlags.RL),
				Game.RA =>  HasFlag(GameFlags.RA),
				Game.RM =>  HasFlag(GameFlags.RM),
				Game.VH =>  HasFlag(GameFlags.VH),
				Game.COL => HasFlag(GameFlags.COL),
				_ => false
			};
		}
		public bool HasPlatform(GamePlatform platform) {
			return platform switch {
				GamePlatform.PC => HasPlatform(PlatformFlags.PC),
				GamePlatform.Android => HasPlatform(PlatformFlags.Android),
				GamePlatform.iOS => HasPlatform(PlatformFlags.iOS),
				GamePlatform.MacOS => HasPlatform(PlatformFlags.MacOS),
				GamePlatform.Vita => HasPlatform(PlatformFlags.Vita),
				GamePlatform.WiiU => HasPlatform(PlatformFlags.WiiU),
				_ => false
			};;
		}
	}
}