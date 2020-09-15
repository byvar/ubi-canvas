using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RegionGfxConfig : CSerializable {
		public Enum_Family Family;
		public GFXPrimitiveParam LineRootPrimitiveParam;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Family = s.Serialize<Enum_Family>(Family, name: "Family");
			LineRootPrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(LineRootPrimitiveParam, name: "LineRootPrimitiveParam");
		}
		public enum Enum_Family {
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
		public override uint? ClassCRC => 0xE84ED7B8;
	}
}

