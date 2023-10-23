namespace UbiArt.ITF {
	public partial class RO2_EnemyBTAIComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if (newSettings.Game == Game.RL) {
					switch (appearType) {
						case Enum_appearType.Basket:
							appearType2 = Enum_appearType2.FromGround;
							break;
						case Enum_appearType.Rope:
							appearType2 = Enum_appearType2.JumpFromZ;
							break;
						default:
							appearType2 = (Enum_appearType2)(int)appearType;
							break;
					}
					useRangedAttack_RL = useRangedAttack ? 1 : 0;
				}
			}
			return this;
		}
	}
}
