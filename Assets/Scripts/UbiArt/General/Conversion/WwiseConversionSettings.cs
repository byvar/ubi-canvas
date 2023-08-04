using System.Collections.Generic;
using System.Linq;
using UbiArt.ITF;

namespace UbiArt {
	public class WwiseConversionSettings {
		public Dictionary<StringID, Entry> Entries { get; set; } = new Dictionary<StringID, Entry>();

		public HashSet<StringID> UsedEntries { get; private set; } = new HashSet<StringID>();

		//public PlaySound_evtTemplate ConvertWwiseEvent(PlayWwise_evtTemplate wwiseEvt) {
		//}

		public void ResetUsedEntries() {
			UsedEntries.Clear();
		}

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
					if(!UsedEntries.Contains(evtGUID)) UsedEntries.Add(evtGUID);
					tpl.WwiseEventGUID = null; // Mark as processed
					tpl._params = GetParams(entry);
					tpl.maxInstances = 5; // or leave it be
					tpl.category = entry.Bus;
					tpl.files = new CListO<Path>(entry.Files.Select(f => new Path(f)).ToList());
					return tpl;
				} else {
					return null;
				}
			}
		}
		public PlaySound_evtTemplate ConvertPlaySound_evtTemplate(PlayWwise_evtTemplate wwiseEvent) {
			var evtGUID = wwiseEvent.WwiseEventGUID;
			var tpl = new PlaySound_evtTemplate();
			if (evtGUID == null)
				return tpl;
			else {
				if (Entries.ContainsKey(evtGUID)) {
					var entry = Entries[evtGUID];
					if (!UsedEntries.Contains(evtGUID)) UsedEntries.Add(evtGUID);
					tpl.Params = GetParams(entry);
					tpl.Category2 = entry.Bus;
					tpl.Sound = new Path(entry.Files.First());
					return tpl;
				} else {
					return tpl;
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
