using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeensyRecapComponent_Template : ActorComponent_Template {
		public uint teensyCount;
		public CList<RO2_TeensyRecapComponent_Template.Teensy> teensies;
		public Path trailPath;
		public Path flashPath;
		public StringID one;
		public StringID two;
		public StringID five;
		public StringID ten;
		public StringID fxAppear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			teensyCount = s.Serialize<uint>(teensyCount, name: "teensyCount");
			teensies = s.SerializeObject<CList<RO2_TeensyRecapComponent_Template.Teensy>>(teensies, name: "teensies");
			trailPath = s.SerializeObject<Path>(trailPath, name: "trailPath");
			flashPath = s.SerializeObject<Path>(flashPath, name: "flashPath");
			one = s.SerializeObject<StringID>(one, name: "one");
			two = s.SerializeObject<StringID>(two, name: "two");
			five = s.SerializeObject<StringID>(five, name: "five");
			ten = s.SerializeObject<StringID>(ten, name: "ten");
			fxAppear = s.SerializeObject<StringID>(fxAppear, name: "fxAppear");
		}
		[Games(GameFlags.RA)]
		public partial class AnimIndices : CSerializable {
			public uint stand;
			public uint standToYeah;
			public uint yeah;
			public uint yeahToStand;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				stand = s.Serialize<uint>(stand, name: "stand");
				standToYeah = s.Serialize<uint>(standToYeah, name: "standToYeah");
				yeah = s.Serialize<uint>(yeah, name: "yeah");
				yeahToStand = s.Serialize<uint>(yeahToStand, name: "yeahToStand");
			}
		}
		[Games(GameFlags.RA)]
		public partial class Teensy : CSerializable {
			public CList<RO2_TeensyRecapComponent_Template.AnimIndices> variationIndices;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				variationIndices = s.SerializeObject<CList<RO2_TeensyRecapComponent_Template.AnimIndices>>(variationIndices, name: "variationIndices");
			}
		}
		public override uint? ClassCRC => 0x63458400;
	}
}

