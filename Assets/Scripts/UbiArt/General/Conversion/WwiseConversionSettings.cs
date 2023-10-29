using System;
using System.Collections.Generic;
using System.Linq;
using UbiArt.ITF;

namespace UbiArt {
	public class WwiseConversionSettings {
		public Dictionary<StringID, Event> Events { get; set; } = new Dictionary<StringID, Event>();

		public HashSet<StringID> UsedEvents { get; private set; } = new HashSet<StringID>();

		public Dictionary<SoundDescriptor_Template, List<SoundDescriptor_Template>> SoundDescriptorMapping { get; set; } = new Dictionary<SoundDescriptor_Template, List<SoundDescriptor_Template>>();

		//public PlaySound_evtTemplate ConvertWwiseEvent(PlayWwise_evtTemplate wwiseEvt) {
		//}

		public void ResetUsedEvents() {
			UsedEvents.Clear();
		}

		public SoundParams GetParams(Action action) {
			if(action == null) return null;

			var sp = new SoundParams() {
				loop = action.IsLoop ? 1 : 0,
				playMode = action.IsSequence ? SoundParams.PlayMode.Sequence : (action.AvoidRepeat ? SoundParams.PlayMode.RandomRememberLast : SoundParams.PlayMode.Random),
				playMode2 = action.IsSequence ? SoundParams.PlayMode2.Sequence : (action.AvoidRepeat ? SoundParams.PlayMode2.RandomRememberLast : SoundParams.PlayMode2.Random),
				modifiers = new CArrayO<Generic<SoundModifier>>() {
					new Generic<SoundModifier>(new SpatializedPanning() {
						sizeOf = 12,
						widthMin = 0.5f,
						widthMax = 1.8f
					}),
					new Generic<SoundModifier>(new ScreenRollOff() {
						sizeOf = 16,
						distanceMin = 0.5f,
						distanceMax = 2f,
					}),
				}
			};

			// Pitch calculation
			float pitchMin = 0f, pitchMax = 0f;
			float CalculateLegendsPitch(float value) => (float)Math.Pow(2, value / 1200f); // wwise pitch is in cents
			foreach (var prop in action.Properties) {
				if (prop.Name == "0x02 [Pitch]") {
					pitchMin = prop.Value;
					pitchMax = prop.Value;
				}
			}
			foreach (var prop in action.RangedProperties) {
				if (prop.Name == "0x02 [Pitch]") {
					pitchMin += prop.Min;
					pitchMax += prop.Max;
				}
			}
			sp.randomPitchMin = CalculateLegendsPitch(pitchMin);
			sp.randomPitchMax = CalculateLegendsPitch(pitchMax);

			// Volume calculation
			float volMin = 0f, volMax = 0f;

			foreach (var prop in action.Properties) {
				if (prop.Name == "0x00 [Volume]") {
					volMin = prop.Value;
					volMax = prop.Value;
				}
			}
			foreach (var prop in action.RangedProperties) {
				if (prop.Name == "0x00 [Volume]") {
					volMin += prop.Min;
					volMax += prop.Max;
				}
			}
			sp.randomVolMin = new Volume(volMin);
			sp.randomVolMax = new Volume(volMax);
			return sp;
		}

		public List<SoundDescriptor_Template> CreateSoundDescriptorsFromWwiseDescriptor(SoundDescriptor_Template tpl) {
			var guid = tpl.WwiseEventGUID;
			if (guid == null || guid.IsNull || !Events.ContainsKey(guid)) return new List<SoundDescriptor_Template>();

			if (SoundDescriptorMapping.ContainsKey(tpl)) return SoundDescriptorMapping[tpl];

			var ev = Events[guid];
			if (!UsedEvents.Contains(guid)) UsedEvents.Add(guid);
			List<SoundDescriptor_Template> soundDescriptors = new List<SoundDescriptor_Template>();
			foreach (var act in ev.Actions) {
				if(act.IsStop) continue;
				var newTPL = new SoundDescriptor_Template() {
					name = new StringID((uint)act.ID),
					//maxInstances = 5, // or leave it be
					_params = GetParams(act),
					WwiseEventGUID = null, // Mark as processed
					category = act.Bus,
					files = new CListO<Path>(act.Sounds.Select(f => new Path(f.Filename)).ToList()),
					soundPlayAfterdestroy = tpl.soundPlayAfterdestroy,
					limitModeEnum = act.KillNewest ? LimiterDef.LimiterMode.RejectNew : LimiterDef.LimiterMode.StopOldest,
					maxInstances = (uint)(act.MaxInstances ?? uint.MaxValue)
				};
				//newTPL.soundPlayAfterdestroy = (newTPL._params?.loop ?? 0) == 0;
				soundDescriptors.Add(newTPL);
			}
			SoundDescriptorMapping[tpl] = soundDescriptors;

			return soundDescriptors;
		}

		public void ConvertSoundDescriptor(SoundDescriptor_Template tpl) {
			var evtGUID = tpl.WwiseEventGUID;
			if(evtGUID == null || evtGUID.IsNull)
				return;
			else
			{
				if(!SoundDescriptorMapping.ContainsKey(tpl))
					CreateSoundDescriptorsFromWwiseDescriptor(tpl);
				tpl.WwiseEventGUID = null; // Mark as processed
			}
		}
		public PlaySound_evtTemplate ConvertPlaySound_evtTemplate(PlayWwise_evtTemplate wwiseEvent) {
			var evtGUID = wwiseEvent.WwiseEventGUID;
			var tpl = new PlaySound_evtTemplate();
			if (evtGUID == null || evtGUID.IsNull)
				return tpl;
			else {
				// Sadly not a great conversion...
				if (Events.ContainsKey(evtGUID) && !(Events[evtGUID].Actions?.FirstOrDefault()?.IsLoop ?? false)) {
					var entry = Events[evtGUID];
					if (entry.Actions.Count > 1) {
						wwiseEvent?.UbiArtContext?.SystemLogger?.LogDebug($"Converting PlayWwise_evtTemplate with GUID {evtGUID}: More than 1 action!");
					}
					var action = entry.Actions.FirstOrDefault(act => !act.IsStop);
					if (action != null) {
						if (!UsedEvents.Contains(evtGUID)) UsedEvents.Add(evtGUID);
						tpl.Params = GetParams(action);
						tpl.Category2 = action.Bus;
						tpl.Sound = new Path(action.Sounds.FirstOrDefault()?.Filename);
					}
					return tpl;
				} else {
					return tpl;
				}
			}
		}

		public class Event {
			public WwiseItem Item { get; set; }
			public string Name { get; set; }
			public List<Action> Actions { get; set; } = new List<Action>();
		}
		public class Action {
			public long ID { get; set; }
			public long? ExtID { get; set; }
			public bool IsLoop { get; set; }
			public bool IsStop { get; set; }
			public StringID Bus { get; set; }
			public List<Sound> Sounds { get; set; } = new List<Sound>();
			public List<Property> Properties { get; set; } = new List<Property>();
			public List<RangedProperty> RangedProperties { get; set; } = new List<RangedProperty>();

			public bool KillNewest { get; set; }
			public bool IsSequence { get; set; }
			public long? MaxInstances { get; set; }
			public bool AvoidRepeat { get; set; }
		}
		public class Sound {
			public string Filename { get; set; }
		}
		public class Property {
			public string Name { get; set; }
			public float Value { get; set; }
		}
		public class RangedProperty {
			public string Name { get; set; }
			public float Min { get; set; }
			public float Max { get; set; }
		}
	}
}
