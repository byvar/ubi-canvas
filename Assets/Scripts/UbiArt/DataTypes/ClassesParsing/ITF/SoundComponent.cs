using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL) {
				var firstComponent = actor.GetComponent<SoundComponent>();
				if (firstComponent != null && this != firstComponent) {
					return null;
				}
			}
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
			return this;
		}
	}
}
