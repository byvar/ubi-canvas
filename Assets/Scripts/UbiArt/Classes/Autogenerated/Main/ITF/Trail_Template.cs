using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class Trail_Template : CSerializable {
		[Serialize("texture"           )] public Path texture;
		[Serialize("material"          )] public GFXMaterialSerializable material;
		[Serialize("nbFrames"          )] public uint nbFrames;
		[Serialize("fixTrailLenght"    )] public uint fixTrailLenght;
		[Serialize("trailFaidingTime"  )] public float trailFaidingTime;
		[Serialize("thicknessBegin"    )] public float thicknessBegin;
		[Serialize("thicknessEnd"      )] public float thicknessEnd;
		[Serialize("alphaBegin"        )] public float alphaBegin;
		[Serialize("alphaEnd"          )] public float alphaEnd;
		[Serialize("trailBlending"     )] public float trailBlending;
		[Serialize("fadeLength"        )] public float fadeLength;
		[Serialize("tesselateMaxLength")] public float tesselateMaxLength;
		[Serialize("tesselateMinLength")] public float tesselateMinLength;
		[Serialize("color"             )] public Color color;
		[Serialize("attachBone"        )] public StringID attachBone;
		[Serialize("Path__0"           )] public Path Path__0;
		[Serialize("uint__1"           )] public uint uint__1;
		[Serialize("float__2"          )] public float float__2;
		[Serialize("float__3"          )] public float float__3;
		[Serialize("float__4"          )] public float float__4;
		[Serialize("float__5"          )] public float float__5;
		[Serialize("float__6"          )] public float float__6;
		[Serialize("float__7"          )] public float float__7;
		[Serialize("float__8"          )] public float float__8;
		[Serialize("Enum_RJR_0__9"     )] public Enum_RJR_0 Enum_RJR_0__9;
		[Serialize("Color__10"         )] public Color Color__10;
		[Serialize("StringID__11"      )] public StringID StringID__11;
		[Serialize("Path__12"          )] public Path Path__12;
		[Serialize("uint__13"          )] public uint uint__13;
		[Serialize("float__14"         )] public float float__14;
		[Serialize("float__15"         )] public float float__15;
		[Serialize("float__16"         )] public float float__16;
		[Serialize("float__17"         )] public float float__17;
		[Serialize("float__18"         )] public float float__18;
		[Serialize("float__19"         )] public float float__19;
		[Serialize("float__20"         )] public float float__20;
		[Serialize("Enum_RFR_0__21"    )] public Enum_RFR_0 Enum_RFR_0__21;
		[Serialize("Color__22"         )] public Color Color__22;
		[Serialize("StringID__23"      )] public StringID StringID__23;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(Path__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(Enum_RJR_0__9));
				SerializeField(s, nameof(Color__10));
				SerializeField(s, nameof(StringID__11));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Path__12));
				SerializeField(s, nameof(uint__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(Enum_RFR_0__21));
				SerializeField(s, nameof(Color__22));
				SerializeField(s, nameof(StringID__23));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(nbFrames));
				SerializeField(s, nameof(fixTrailLenght));
				SerializeField(s, nameof(trailFaidingTime));
				SerializeField(s, nameof(thicknessBegin));
				SerializeField(s, nameof(thicknessEnd));
				SerializeField(s, nameof(alphaBegin));
				SerializeField(s, nameof(alphaEnd));
				SerializeField(s, nameof(trailBlending));
				SerializeField(s, nameof(fadeLength));
				SerializeField(s, nameof(tesselateMaxLength));
				SerializeField(s, nameof(tesselateMinLength));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(attachBone));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
		}
	}
}

