using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UbiArt.ITF {
	public partial class BTDeciderHasFact_Template {
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
						if (factsHave != null) {
							factsHave.Remove(new StringID(0x84E2B5AB));
						}
						if (factsNotHave != null) {
							factsNotHave.Remove(new StringID(0x84E2B5AB));
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
