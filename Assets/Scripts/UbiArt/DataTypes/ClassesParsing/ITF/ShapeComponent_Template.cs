﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class ShapeComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL && (oldSettings.Game == Game.RA || oldSettings.Game == Game.RM)) {
				if ((polyline == null || polyline.IsNull) && (AnimPolylineList != null && AnimPolylineList.Count > 0)) {
					polyline = AnimPolylineList.FirstOrDefault(sid => sid != null && !sid.IsNull);
				}
			}
			return this;
		}
	}
}
