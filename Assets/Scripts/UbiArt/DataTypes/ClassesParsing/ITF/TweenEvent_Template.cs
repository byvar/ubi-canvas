using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class TweenEvent_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game) {
					if (_event?.obj?.IsAdventuresExclusive() ?? false) _event = null;
				}
			}
			previousSettings = settings;
		}
	}
}
