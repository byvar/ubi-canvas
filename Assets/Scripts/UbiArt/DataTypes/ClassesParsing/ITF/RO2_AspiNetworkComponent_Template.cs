using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class RO2_AspiNetworkComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.game == Settings.Game.RL) {
				if (fxData == null || fxData.Count == 0) {
					fxData.Add(new FxDataNet() {
						playerFamily = "rayman",
						fxIn = new StringID(0xF91DE660),
						fxOut = new StringID(0x1CC71274)
					});
					fxData.Add(new FxDataNet() {
						playerFamily = "globox",
						fxIn = new StringID(0x2F64EAF3),
						fxOut = new StringID(0xC1A6A910)
					});
					fxData.Add(new FxDataNet() {
						playerFamily = "teensy",
						fxIn = new StringID(0x2399881C),
						fxOut = new StringID(0x95516AFA)
					});
					fxData.Add(new FxDataNet() {
						playerFamily = "Barbara",
						fxIn = new StringID(0x2399881C),
						fxOut = new StringID(0x95516AFA)
					});
				}
			}
			return this;
		}
	}
}
