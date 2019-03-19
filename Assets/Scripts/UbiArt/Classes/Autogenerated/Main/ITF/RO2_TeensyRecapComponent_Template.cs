using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeensyRecapComponent_Template : ActorComponent_Template {
		[Serialize("teensyCount")] public uint teensyCount;
		[Serialize("teensies"   )] public CList<RO2_TeensyRecapComponent_Template.Teensy> teensies;
		[Serialize("trailPath"  )] public Path trailPath;
		[Serialize("flashPath"  )] public Path flashPath;
		[Serialize("one"        )] public StringID one;
		[Serialize("two"        )] public StringID two;
		[Serialize("five"       )] public StringID five;
		[Serialize("ten"        )] public StringID ten;
		[Serialize("fxAppear"   )] public StringID fxAppear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(teensyCount));
			SerializeField(s, nameof(teensies));
			SerializeField(s, nameof(trailPath));
			SerializeField(s, nameof(flashPath));
			SerializeField(s, nameof(one));
			SerializeField(s, nameof(two));
			SerializeField(s, nameof(five));
			SerializeField(s, nameof(ten));
			SerializeField(s, nameof(fxAppear));
		}
		[Games(GameFlags.RA)]
		public partial class AnimIndices : CSerializable {
			[Serialize("stand"      )] public uint stand;
			[Serialize("standToYeah")] public uint standToYeah;
			[Serialize("yeah"       )] public uint yeah;
			[Serialize("yeahToStand")] public uint yeahToStand;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(stand));
				SerializeField(s, nameof(standToYeah));
				SerializeField(s, nameof(yeah));
				SerializeField(s, nameof(yeahToStand));
			}
		}
		[Games(GameFlags.RA)]
		public partial class Teensy : CSerializable {
			[Serialize("variationIndices")] public CList<RO2_TeensyRecapComponent_Template.AnimIndices> variationIndices;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(variationIndices));
			}
		}
		public override uint? ClassCRC => 0x63458400;
	}
}

