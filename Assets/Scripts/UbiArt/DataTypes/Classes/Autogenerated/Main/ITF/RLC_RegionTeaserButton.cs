namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RegionTeaserButton : ActorComponent {
		public Enum_Region Region;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Region = s.Serialize<Enum_Region>(Region, name: "Region");
		}
		public enum Enum_Region {
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
		public override uint? ClassCRC => 0x3266ED8D;
	}
}

