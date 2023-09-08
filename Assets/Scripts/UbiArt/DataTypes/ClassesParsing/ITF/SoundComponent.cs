using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				//soundList = null;
				if (soundList != null) {
					if ((oldSettings.Game == Game.RA || oldSettings.Game == Game.RM)
						&& newSettings.Game == Game.RL) {
						if (context.HasSettings<ConversionSettings>()) {
							var conv = context.GetSettings<ConversionSettings>();
							if (conv.WwiseConversionSettings != null) {
								var newSounds = soundList.SelectMany(s => conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s));
								foreach (var s in newSounds) {
									if(!soundList.Any(snd => snd.name == s.name)) soundList.Add(s);
								}
							}
						}
					}
				}
			}
			if (newSettings.Game == Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is SoundComponent c) {
						return (this == c) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
