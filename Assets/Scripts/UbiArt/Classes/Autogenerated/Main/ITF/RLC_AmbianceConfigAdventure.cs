using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceConfigAdventure : RLC_AmbianceConfig {
		[Serialize("GraphicalFamily")] public Enum_GraphicalFamily GraphicalFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(GraphicalFamily));
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

