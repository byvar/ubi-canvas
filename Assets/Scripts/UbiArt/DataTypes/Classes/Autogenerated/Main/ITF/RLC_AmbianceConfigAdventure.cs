using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfigAdventure : RLC_AmbianceConfig {
		public Enum_GraphicalFamily GraphicalFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GraphicalFamily = s.Serialize<Enum_GraphicalFamily>(GraphicalFamily, name: "GraphicalFamily");
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
		public override uint? ClassCRC => 0x12C35BE2;
	}
}

