using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class BusDef : CSerializable {
		public StringID name;
		public CList<StringID> outputs;
		public Volume volume;
		public float filterFrequency;
		public float filterQ;
		public FilterType filterType;
		public bool hasReverb;
		public int reverbActive;
		public ReverbPreset reverbPreset;
		public CArray<Generic<SoundModifier>> modifiers;
		public int pauseSensitive;

		
		public FilterType2 filterType2;
		public uint outDevices;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RO) {
				name = s.SerializeObject<StringID>(name, name: "name");
				outputs = s.SerializeObject<CList<StringID>>(outputs, name: "outputs");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				filterFrequency = s.Serialize<float>(filterFrequency, name: "filterFrequency");
				filterQ = s.Serialize<float>(filterQ, name: "filterQ");
				filterType = s.Serialize<FilterType>(filterType, name: "filterType");
				hasReverb = s.Serialize<bool>(hasReverb, name: "hasReverb");
				reverbActive = s.Serialize<int>(reverbActive, name: "reverbActive");
				reverbPreset = s.Serialize<ReverbPreset>(reverbPreset, name: "reverbPreset");
				modifiers = s.SerializeObject<CArray<Generic<SoundModifier>>>(modifiers, name: "modifiers");
				pauseSensitive = s.Serialize<int>(pauseSensitive, name: "pauseSensitive");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				outputs = s.SerializeObject<CList<StringID>>(outputs, name: "outputs");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				filterFrequency = s.Serialize<float>(filterFrequency, name: "filterFrequency");
				filterType2 = s.Serialize<FilterType2>(filterType2, name: "filterType2");
				modifiers = s.SerializeObject<CArray<Generic<SoundModifier>>>(modifiers, name: "modifiers");
				outDevices = s.Serialize<uint>(outDevices, name: "outDevices");
			}
		}
		public enum FilterType {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
			[Serialize("FilterType_Notch"   )] Notch = 3,
			[Serialize("FilterType_None"    )] None = 4,
		}
		public enum FilterType2 {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
		}
		public enum ReverbPreset {
			[Serialize("ReverbPreset_DEFAULT"        )] DEFAULT = 0,
			[Serialize("ReverbPreset_GENERIC"        )] GENERIC = 1,
			[Serialize("ReverbPreset_PADDEDCELL"     )] PADDEDCELL = 2,
			[Serialize("ReverbPreset_ROOM"           )] ROOM = 3,
			[Serialize("ReverbPreset_BATHROOM"       )] BATHROOM = 4,
			[Serialize("ReverbPreset_LIVINGROOM"     )] LIVINGROOM = 5,
			[Serialize("ReverbPreset_STONEROOM"      )] STONEROOM = 6,
			[Serialize("ReverbPreset_AUDITORIUM"     )] AUDITORIUM = 7,
			[Serialize("ReverbPreset_CONCERTHALL"    )] CONCERTHALL = 8,
			[Serialize("ReverbPreset_CAVE"           )] CAVE = 9,
			[Serialize("ReverbPreset_ARENA"          )] ARENA = 10,
			[Serialize("ReverbPreset_HANGAR"         )] HANGAR = 11,
			[Serialize("ReverbPreset_CARPETEDHALLWAY")] CARPETEDHALLWAY = 12,
			[Serialize("ReverbPreset_HALLWAY"        )] HALLWAY = 13,
			[Serialize("ReverbPreset_STONECORRIDOR"  )] STONECORRIDOR = 14,
			[Serialize("ReverbPreset_ALLEY"          )] ALLEY = 15,
			[Serialize("ReverbPreset_FOREST"         )] FOREST = 16,
			[Serialize("ReverbPreset_CITY"           )] CITY = 17,
			[Serialize("ReverbPreset_MOUNTAINS"      )] MOUNTAINS = 18,
			[Serialize("ReverbPreset_QUARRY"         )] QUARRY = 19,
			[Serialize("ReverbPreset_PLAIN"          )] PLAIN = 20,
			[Serialize("ReverbPreset_PARKINGLOT"     )] PARKINGLOT = 21,
			[Serialize("ReverbPreset_SEWERPIPE"      )] SEWERPIPE = 22,
			[Serialize("ReverbPreset_UNDERWATER"     )] UNDERWATER = 23,
			[Serialize("ReverbPreset_SMALLROOM"      )] SMALLROOM = 24,
			[Serialize("ReverbPreset_MEDIUMROOM"     )] MEDIUMROOM = 25,
			[Serialize("ReverbPreset_LARGEROOM"      )] LARGEROOM = 26,
			[Serialize("ReverbPreset_MEDIUMHALL"     )] MEDIUMHALL = 27,
			[Serialize("ReverbPreset_LARGEHALL"      )] LARGEHALL = 28,
			[Serialize("ReverbPreset_PLATE"          )] PLATE = 29,
			[Serialize("ReverbPreset_CUSTOM"         )] CUSTOM = 31,
			[Serialize("ReverbPreset_NONE"           )] NONE = 32,
		}
	}
}

