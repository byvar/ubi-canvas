using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class ShapeDetectorComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.game == Settings.Game.RL) {
				if (animPolylineID == null || animPolylineID.IsNull) {
					if (animPolylineIDList != null) {
						animPolylineID = animPolylineIDList
							?.FirstOrDefault(pl => pl.AnimPolyName != null && !pl.AnimPolyName.IsNull)
							?.AnimPolyName ?? animPolylineID;
					}
				}
			}
			return this;
		}
	}
}
