using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class FontEffect_Template : CSerializable {
		[Serialize("name"            )] public StringID name;
		[Serialize("flags"           )] public Enum_flags flags;
		[Serialize("type"            )] public Enum_type type;
		[Serialize("fadeinStart"     )] public float fadeinStart;
		[Serialize("fadeinEnd"       )] public float fadeinEnd;
		[Serialize("fadeoutStart"    )] public float fadeoutStart;
		[Serialize("fadeoutEnd"      )] public float fadeoutEnd;
		[Serialize("speedMin"        )] public float speedMin;
		[Serialize("speedMax"        )] public float speedMax;
		[Serialize("static"          )] public bool _static;
		[Serialize("staticSeed"      )] public float staticSeed;
		[Serialize("min"             )] public float min;
		[Serialize("max"             )] public float max;
		[Serialize("limit"           )] public float limit;
		[Serialize("value"           )] public float value;
		[Serialize("rotateCycle"     )] public float rotateCycle;
		[Serialize("rotateSeedFactor")] public float rotateSeedFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(flags));
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(fadeinStart));
			SerializeField(s, nameof(fadeinEnd));
			SerializeField(s, nameof(fadeoutStart));
			SerializeField(s, nameof(fadeoutEnd));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(_static));
			SerializeField(s, nameof(staticSeed));
			SerializeField(s, nameof(min));
			SerializeField(s, nameof(max));
			SerializeField(s, nameof(limit));
			SerializeField(s, nameof(value));
			SerializeField(s, nameof(rotateCycle));
			SerializeField(s, nameof(rotateSeedFactor));
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

