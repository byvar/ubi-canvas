using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class ShapeComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (newSettings.game == Settings.Game.RL && (oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM)) {
				if ((polyline == null || polyline.IsNull) && (AnimPolylineList != null && AnimPolylineList.Count > 0)) {
					polyline = AnimPolylineList.FirstOrDefault(sid => sid != null && !sid.IsNull);
				}
			}
			return this;
		}
	}
}
