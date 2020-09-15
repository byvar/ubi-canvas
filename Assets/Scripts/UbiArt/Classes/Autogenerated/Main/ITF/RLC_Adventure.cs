using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Adventure : CSerializable {
		public PathRef Path;
		public uint AdventureIdMin;
		public uint AdventureIdMax;
		public Enum_GraphicalFamily GraphicalFamily;
		public uint Difficulty;
		public uint LuaIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path = s.SerializeObject<PathRef>(Path, name: "Path");
			AdventureIdMin = s.Serialize<uint>(AdventureIdMin, name: "AdventureIdMin");
			AdventureIdMax = s.Serialize<uint>(AdventureIdMax, name: "AdventureIdMax");
			GraphicalFamily = s.Serialize<Enum_GraphicalFamily>(GraphicalFamily, name: "GraphicalFamily");
			Difficulty = s.Serialize<uint>(Difficulty, name: "Difficulty");
			LuaIndex = s.Serialize<uint>(LuaIndex, name: "LuaIndex");
		}
		public enum Enum_GraphicalFamily {
			[Serialize("_unknown"     )] _unknown = 0,
			[Serialize("Shaolin"      )] Shaolin = 1,
			[Serialize("Medieval"     )] Medieval = 2,
			[Serialize("ToadStory"    )] ToadStory = 3,
			[Serialize("Desert"       )] Desert = 4,
			[Serialize("UnderWater"   )] UnderWater = 5,
			[Serialize("Greece"       )] Greece = 6,
			[Serialize("LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("Intro"        )] Intro = 8,
		}
		public override uint? ClassCRC => 0x98062F6E;
	}
}

