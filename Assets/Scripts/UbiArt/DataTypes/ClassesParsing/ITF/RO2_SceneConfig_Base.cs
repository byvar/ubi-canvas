using System;

namespace UbiArt.ITF {
	public partial class RO2_SceneConfig_Base {
		public override SceneConfig Convert(Context context, Settings oldSettings, Settings newSettings) {
			base.Convert(context, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL) && !(oldSettings.Game == Game.RL)) {
					var attr = (GamesAttribute)Attribute.GetCustomAttribute(GetType(), typeof(GamesAttribute));
					if (attr != null) {
						if (!attr.HasGame(newSettings.Game) || !attr.HasPlatform(newSettings.Platform)) {
							return Merger.Merge<RO2_SceneConfig_Base>(this);
						}
					}
				}
			}
			return this;
		}
	}
}
