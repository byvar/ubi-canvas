using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class GraphicComponent : ActorComponent {
		[Serialize("ColorFactor"                  )] public Color ColorFactor;
		[Serialize("ColorFog"                     )] public Color ColorFog;
		[Serialize("PrimitiveParameters"          )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("colorComputerTagId"           )] public uint colorComputerTagId;
		[Serialize("renderInTarget"               )] public bool renderInTarget;
		[Serialize("disableLight"                 )] public int disableLight;
		[Serialize("disableShadow"                )] public int disableShadow;
		[Serialize("depthOffset"                  )] public float depthOffset;
		[Serialize("AlphaInit"                    )] public float AlphaInit;
		[Serialize("highlightFrontLightBrightness")] public float highlightFrontLightBrightness;
		[Serialize("highlightOutlineColor"        )] public Color highlightOutlineColor;
		[Serialize("highlightOutlineWidth"        )] public float highlightOutlineWidth;
		[Serialize("ColorFog_Red"                 )] public float ColorFog_Red;
		[Serialize("ColorFog_Green"               )] public float ColorFog_Green;
		[Serialize("ColorFog_Blu"                 )] public float ColorFog_Blu;
		[Serialize("fogfactor"                    )] public float fogfactor;
		[Serialize("useStaticFog"                 )] public int useStaticFog;
		[Serialize("renderInReflection"           )] public int renderInReflection;
		[Serialize("float__0"                     )] public float float__0;
		[Serialize("float__1"                     )] public float float__1;
		[Serialize("float__2"                     )] public float float__2;
		[Serialize("Color__3"                     )] public Color Color__3;
		[Serialize("Color__4"                     )] public Color Color__4;
		[Serialize("uint__5"                      )] public uint uint__5;
		[Serialize("int__6"                       )] public int int__6;
		[Serialize("int__7"                       )] public int int__7;
		[Serialize("Color__8"                     )] public Color Color__8;
		[Serialize("Color__9"                     )] public Color Color__9;
		[Serialize("bool__10"                     )] public bool bool__10;
		[Serialize("bool__11"                     )] public bool bool__11;
		[Serialize("GFXPrimitiveParam__12"        )] public GFXPrimitiveParam GFXPrimitiveParam__12;
		[Serialize("uint__13"                     )] public uint uint__13;
		[Serialize("bool__14"                     )] public bool bool__14;
		[Serialize("int__15"                      )] public int int__15;
		[Serialize("int__16"                      )] public int int__16;
		[Serialize("float__17"                    )] public float float__17;
		[Serialize("float__18"                    )] public float float__18;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(float__0));
					SerializeField(s, nameof(float__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(Color__3));
					SerializeField(s, nameof(Color__4));
					SerializeField(s, nameof(uint__5));
					SerializeField(s, nameof(int__6));
					SerializeField(s, nameof(int__7));
				}
			} else if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ColorFog_Red));
					SerializeField(s, nameof(ColorFog_Green));
					SerializeField(s, nameof(ColorFog_Blu));
					SerializeField(s, nameof(fogfactor));
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
					SerializeField(s, nameof(useStaticFog));
					SerializeField(s, nameof(renderInReflection));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
					SerializeField(s, nameof(disableShadow));
					SerializeField(s, nameof(depthOffset));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(Color__8));
					SerializeField(s, nameof(Color__9));
					SerializeField(s, nameof(bool__10));
					SerializeField(s, nameof(bool__11));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(GFXPrimitiveParam__12));
					SerializeField(s, nameof(uint__13));
					SerializeField(s, nameof(bool__14));
					SerializeField(s, nameof(int__15));
					SerializeField(s, nameof(int__16));
					SerializeField(s, nameof(float__17));
					SerializeField(s, nameof(float__18));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
					SerializeField(s, nameof(disableShadow));
					SerializeField(s, nameof(depthOffset));
					SerializeField(s, nameof(AlphaInit));
					SerializeField(s, nameof(highlightFrontLightBrightness));
					SerializeField(s, nameof(highlightOutlineColor));
					SerializeField(s, nameof(highlightOutlineWidth));
				}
			}
		}
		public override uint? ClassCRC => 0x804757FE;
	}
}

