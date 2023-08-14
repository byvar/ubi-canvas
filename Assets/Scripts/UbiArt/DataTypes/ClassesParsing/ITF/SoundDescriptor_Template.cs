﻿using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class SoundDescriptor_Template {

		public SoundDescriptor_Template() {
			maxInstances = 0xFFFFFFFF;
			outDevices = 0xFFFFFFFF;
			_params = new SoundParams() {
				filterType2 = SoundParams.FilterType2.HighPass,
				randomPitchMax = 1,
				randomPitchMin = 1,
				metronomeType = 0xFFFFFFFF,
				playOnNext = 0xFFFFFFFF,
			};
		}

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
						if (c.HasSettings<ConversionSettings>()) {
							var conv = c.GetSettings<ConversionSettings>();
							if (conv.WwiseConversionSettings != null) {
								//conv.WwiseConversionSettings.ConvertSoundDescriptor(this);
							}
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
