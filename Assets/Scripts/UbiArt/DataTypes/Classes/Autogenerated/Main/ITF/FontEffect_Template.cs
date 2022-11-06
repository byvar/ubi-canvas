using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class FontEffect_Template : CSerializable {
		public StringID name;
		public Enum_flags flags;
		public Enum_type type;
		public float fadeinStart;
		public float fadeinEnd;
		public float fadeoutStart;
		public float fadeoutEnd;
		public float speedMin;
		public float speedMax;
		public bool _static;
		public float staticSeed;
		public float min;
		public float max;
		public float limit;
		public float value;
		public float rotateCycle;
		public float rotateSeedFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			flags = s.Serialize<Enum_flags>(flags, name: "flags");
			type = s.Serialize<Enum_type>(type, name: "type");
			fadeinStart = s.Serialize<float>(fadeinStart, name: "fadeinStart");
			fadeinEnd = s.Serialize<float>(fadeinEnd, name: "fadeinEnd");
			fadeoutStart = s.Serialize<float>(fadeoutStart, name: "fadeoutStart");
			fadeoutEnd = s.Serialize<float>(fadeoutEnd, name: "fadeoutEnd");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			_static = s.Serialize<bool>(_static, name: "static");
			staticSeed = s.Serialize<float>(staticSeed, name: "staticSeed");
			min = s.Serialize<float>(min, name: "min");
			max = s.Serialize<float>(max, name: "max");
			limit = s.Serialize<float>(limit, name: "limit");
			value = s.Serialize<float>(value, name: "value");
			rotateCycle = s.Serialize<float>(rotateCycle, name: "rotateCycle");
			rotateSeedFactor = s.Serialize<float>(rotateSeedFactor, name: "rotateSeedFactor");
		}
		public enum Enum_flags {
			[Serialize("none"                  )] none = 0,
			[Serialize("LanguageJapaneseExcept")] LanguageJapaneseExcept = 1,
		}
		public enum Enum_type {
			[Serialize("shiftY"         )] shiftY = 0,
			[Serialize("scale"          )] scale = 1,
			[Serialize("rotate"         )] rotate = 2,
			[Serialize("zoomAlpha"      )] zoomAlpha = 3,
			[Serialize("clampY"         )] clampY = 4,
			[Serialize("shiftYandRotate")] shiftYandRotate = 5,
		}
	}
}

