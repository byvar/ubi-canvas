using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class BusDef : CSerializable {
		[Serialize("name"           )] public StringID name;
		[Serialize("outputs"        )] public CList<StringID> outputs;
		[Serialize("volume"         )] public Volume volume;
		[Serialize("filterFrequency")] public float filterFrequency;
		[Serialize("filterQ"        )] public float filterQ;
		[Serialize("filterType"     )] public FilterType filterType;
		[Serialize("hasReverb"      )] public bool hasReverb;
		[Serialize("reverbActive"   )] public int reverbActive;
		[Serialize("reverbPreset"   )] public ReverbPreset reverbPreset;
		[Serialize("modifiers"      )] public CArray<Generic<SoundModifier>> modifiers;
		[Serialize("pauseSensitive" )] public int pauseSensitive;

		
		[Serialize("filterType"     )] public FilterType2 filterType2;
		[Serialize("outDevices"     )] public uint outDevices;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(outputs));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(filterFrequency));
				SerializeField(s, nameof(filterQ));
				SerializeField(s, nameof(filterType));
				SerializeField(s, nameof(hasReverb));
				SerializeField(s, nameof(reverbActive));
				SerializeField(s, nameof(reverbPreset));
				SerializeField(s, nameof(modifiers));
				SerializeField(s, nameof(pauseSensitive));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(outputs));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(filterFrequency));
				SerializeField(s, nameof(filterType2));
				SerializeField(s, nameof(modifiers));
				SerializeField(s, nameof(outDevices));
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

