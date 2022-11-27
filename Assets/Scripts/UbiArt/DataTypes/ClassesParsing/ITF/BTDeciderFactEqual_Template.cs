using System.Collections.Generic;
using System.Diagnostics;

namespace UbiArt.ITF {
	public partial class BTDeciderFactEqual_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if ((previousSettings.game == Settings.Game.RA || previousSettings.game == Settings.Game.RM) 
						&& settings.game == Settings.Game.RL) {
						type = (EValueType)(int)typeRA;
						inferiorEnum = inferior ? type : 0;
						superiorEnum = superior ? type : 0;
					}
				}
			}
			previousSettings = settings;
		}
	}
}
