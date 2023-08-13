﻿namespace UbiArt.ITF {
	public partial class RO2_EnemyBTAIComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if (newSettings.game == Settings.Game.RL) {
					if (appearType != Enum_appearType.Basket && appearType != Enum_appearType.Rope) {
						appearType2 = (Enum_appearType2)(int)appearType;
					}
					useRangedAttack_RL = useRangedAttack ? 1 : 0;
				}
			}
			return this;
		}
	}
}
