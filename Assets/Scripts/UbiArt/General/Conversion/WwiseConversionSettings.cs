using System.Collections.Generic;
using UbiArt.ITF;

namespace UbiArt {
	public class WwiseConversionSettings {
		public Dictionary<StringID, Entry> Entries { get; set; } = new Dictionary<StringID, Entry>();

		//public PlaySound_evtTemplate ConvertWwiseEvent(PlayWwise_evtTemplate wwiseEvt) {
		//}

		public SoundParams GetParams(Entry entry) {
			if(entry == null) return null;

			var sp = new SoundParams() {
				loop = entry.IsLoop ? 1 : 0,
				playMode = SoundParams.PlayMode.Random,
				playMode2 = SoundParams.PlayMode2.Random,
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
			return sp;
		}
		public SoundDescriptor_Template ConvertSoundDescriptor(SoundDescriptor_Template tpl) {
			var evtGUID = tpl.WwiseEventGUID;
			if(evtGUID == null)
				return tpl;
			else
			{
				if (Entries.ContainsKey(evtGUID)) {
					var entry = Entries[evtGUID];
					tpl.WwiseEventGUID = null; // Mark as processed
					tpl._params = GetParams(entry);
					tpl.maxInstances = 5; // or leave it be
					tpl.category = entry.Bus;
					return tpl;
				} else {
					return null;
				}
			}
		}

		public class Entry {
			public WwiseItem Item { get; set; }
			public string Name { get; set; }
			public bool IsLoop { get; set; }
			public StringID Bus { get; set; }
			public List<string> Files { get; set; }
		}
	}
}
