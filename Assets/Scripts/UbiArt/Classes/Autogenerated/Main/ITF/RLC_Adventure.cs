using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Adventure : CSerializable {
		[Serialize("Path"           )] public PathRef Path;
		[Serialize("AdventureIdMin" )] public uint AdventureIdMin;
		[Serialize("AdventureIdMax" )] public uint AdventureIdMax;
		[Serialize("GraphicalFamily")] public Enum_GraphicalFamily GraphicalFamily;
		[Serialize("Difficulty"     )] public uint Difficulty;
		[Serialize("LuaIndex"       )] public uint LuaIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path));
			SerializeField(s, nameof(AdventureIdMin));
			SerializeField(s, nameof(AdventureIdMax));
			SerializeField(s, nameof(GraphicalFamily));
			SerializeField(s, nameof(Difficulty));
			SerializeField(s, nameof(LuaIndex));
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

