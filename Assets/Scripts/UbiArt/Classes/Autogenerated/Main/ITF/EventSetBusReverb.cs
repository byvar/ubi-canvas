using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventSetBusReverb : Event {
		public StringID bus;
		public int changeActivation;
		public int activate;
		public int changePreset;
		public ReverbPreset preset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bus = s.SerializeObject<StringID>(bus, name: "bus");
			changeActivation = s.Serialize<int>(changeActivation, name: "changeActivation");
			activate = s.Serialize<int>(activate, name: "activate");
			changePreset = s.Serialize<int>(changePreset, name: "changePreset");
			preset = s.Serialize<ReverbPreset>(preset, name: "preset");
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
		public override uint? ClassCRC => 0x05E22917;
	}
}

