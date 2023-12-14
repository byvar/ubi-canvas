using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class SoundComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL) {
				var firstComponent = actor.GetComponent<SoundComponent_Template>();
				if(firstComponent != null && this != firstComponent) {
					return null;
				}
			}
			if (oldSettings.Game != newSettings.Game) {
				/*soundList = null;
				inputs = null;
				defaultSound = null;*/
				if (soundList != null) {
					if ((oldSettings.Game == Game.RA || oldSettings.Game == Game.RM)
						&& newSettings.Game == Game.RL) {
						if (context.HasSettings<ConversionSettings>()) {
							var conv = context.GetSettings<ConversionSettings>();
							if (conv.WwiseConversionSettings != null) {
								// Remove broken sound descriptor which can occur in Adventures
								var sounds = soundList.Where(snd => snd != null && (snd.HasWwiseEvent || snd.HasFiles));
								soundList = new CListO<SoundDescriptor_Template>(sounds?.ToList());


								var newSounds = soundList.SelectMany(s => conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s)).ToList();
								foreach (var s in newSounds) {
									if (!soundList.Any(snd => snd.name == s.name)) soundList.Add(s);
								}
								var fxComponent = actor.GetComponent<FXControllerComponent_Template>();
								if (fxComponent != null) {
									foreach (var fx in fxComponent.fxControlList) {
										if (fx.sounds != null && fx.sounds.Any()) {
											var soundDescs = fx.sounds.Select(sid => soundList.FirstOrDefault(s => s.name == sid));
											var newNames = soundDescs.SelectMany(s =>
												s == null ? new List<SoundDescriptor_Template>() :
												((s.WwiseEventGUID?.IsNull ?? true) && s.HasFiles) ? new List<SoundDescriptor_Template>() { s } : // Keep fx references to sounds that already have files
												conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(s)
											).Select(s => s.name);
											fx.sounds = new CListO<StringID>(newNames.ToList());
										}
									}
								}

								// Convert "defaultSound"
								if (defaultSound != null && !defaultSound.IsNull) {
									var defaultSoundDesc = soundList.FirstOrDefault(snd => snd.name == defaultSound);
									if (defaultSoundDesc?.WwiseEventGUID != null && !defaultSoundDesc.WwiseEventGUID.IsNull) {
										var convDescs = conv.WwiseConversionSettings.CreateSoundDescriptorsFromWwiseDescriptor(defaultSoundDesc);
										if (convDescs != null && convDescs.Any()) {
											defaultSound = new StringID(convDescs.First().name.stringID);
										}
									}
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
