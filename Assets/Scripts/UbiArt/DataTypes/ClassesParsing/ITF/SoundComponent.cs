using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				//soundList = null;
				if (soundList != null) {
					if ((oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM)
						&& newSettings.game == Settings.Game.RL) {
						if (context.HasSettings<ConversionSettings>()) {
							var conv = context.GetSettings<ConversionSettings>();
							if (conv.WwiseConversionSettings != null) {
								var newSounds = soundList.SelectMany(s => conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s));
								foreach (var s in newSounds) {
									soundList.Add(s);
								}
							}
						}
					}
				}
			}
			if (newSettings.game == Settings.Game.RL) {
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
