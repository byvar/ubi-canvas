using System;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class GamesAttribute : Attribute {
		private GameFlags flags;
		public GamesAttribute(GameFlags flags) {
			this.flags = flags;
		}

		public bool HasFlag(GameFlags flag) => flags.HasFlag(flag);

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
	}
}