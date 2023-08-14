﻿using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class SoundComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				/*soundList = null;
				inputs = null;
				defaultSound = null;*/
				if (soundList != null) {
					if ((oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM)
						&& newSettings.game == Settings.Game.RL) {
						if (context.HasSettings<ConversionSettings>()) {
							var conv = context.GetSettings<ConversionSettings>();
							if (conv.WwiseConversionSettings != null) {
								var newSounds = soundList.SelectMany(s => conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s)).ToList();
								foreach (var s in newSounds) {
									if (!soundList.Any(snd => snd.name == s.name)) soundList.Add(s);
								}
								var fxComponent = actor.GetComponent<FXControllerComponent_Template>();
								if (fxComponent != null) {
									foreach (var fx in fxComponent.fxControlList) {
										if (fx.sounds != null && fx.sounds.Any()) {
											var soundDescs = fx.sounds.Select(sid => soundList.FirstOrDefault(s => s.name == sid));
											var newNames = soundDescs.SelectMany(s => s == null ? new List<SoundDescriptor_Template>() : conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s)).Select(s => s.name);
											fx.sounds = new CListO<StringID>(newNames.ToList());
										}
									}
								}
							}
						}
					}
				}
			}
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is SoundComponent_Template c) {
						return (this == c) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
