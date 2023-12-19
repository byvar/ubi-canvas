namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class GraphicComponent : ActorComponent {
		public Color ColorFactor = Color.White;
		public Color ColorFog;
		public GFXPrimitiveParam PrimitiveParameters;
		public uint colorComputerTagId;
		public bool renderInTarget;
		public int disableLight = -1;
		public int disableShadow = -1;
		public float depthOffset;
		public float AlphaInit = 1f;
		public float highlightFrontLightBrightness = -1;
		public Color highlightOutlineColor;
		public float highlightOutlineWidth = -1;
		public float ColorFog_Red;
		public float ColorFog_Green;
		public float ColorFog_Blu;
		public float fogfactor;
		public int useStaticFog;
		public int renderInReflection;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				if(this is SwarmComponent) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					if (!s.HasProperty(CSerializerObject.SerializerProperty.Binary)) {
						ColorFog_Red = s.Serialize<float>(ColorFog_Red, name: "ColorFog_Red");
						ColorFog_Green = s.Serialize<float>(ColorFog_Green, name: "ColorFog_Green");
						ColorFog_Blu = s.Serialize<float>(ColorFog_Blu, name: "ColorFog_Blu");
						fogfactor = s.Serialize<float>(fogfactor, name: "fogfactor");
					}
					ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
					ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
					colorComputerTagId = s.Serialize<uint>(colorComputerTagId, name: "colorComputerTagId");
					renderInTarget = s.Serialize<bool>(renderInTarget, name: "renderInTarget");
					disableLight = s.Serialize<int>(disableLight, name: "disableLight");
				}
			} else if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
						ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
						useStaticFog = s.Serialize<int>(useStaticFog, name: "useStaticFog");
						renderInReflection = s.Serialize<int>(renderInReflection, name: "renderInReflection");
					}
					PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
					colorComputerTagId = s.Serialize<uint>(colorComputerTagId, name: "colorComputerTagId");
					renderInTarget = s.Serialize<bool>(renderInTarget, name: "renderInTarget");
					disableLight = s.Serialize<int>(disableLight, name: "disableLight");
					disableShadow = s.Serialize<int>(disableShadow, name: "disableShadow");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				}
			} else if (s.Settings.Game == Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
						ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
						useStaticFog = s.Serialize<bool>(useStaticFog != 0, name: "useStaticFog", options: CSerializerObject.Options.BoolAsByte) ? 1 : 0;
						renderInReflection = s.Serialize<bool>(renderInReflection != 0, name: "renderInReflection", options: CSerializerObject.Options.BoolAsByte) ? 1 : 0;
					}
					PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
					colorComputerTagId = s.Serialize<uint>(colorComputerTagId, name: "colorComputerTagId");
					renderInTarget = s.Serialize<bool>(renderInTarget, name: "renderInTarget", options: CSerializerObject.Options.BoolAsByte);
					disableLight = s.Serialize<int>(disableLight, name: "disableLight");
					disableShadow = s.Serialize<int>(disableShadow, name: "disableShadow");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				}
			} else if (s.Settings.Game == Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
						ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
						useStaticFog = s.Serialize<int>(useStaticFog, name: "useStaticFog");
						renderInReflection = s.Serialize<int>(renderInReflection, name: "renderInReflection");
					}
					PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
					colorComputerTagId = s.Serialize<uint>(colorComputerTagId, name: "colorComputerTagId");
					renderInTarget = s.Serialize<bool>(renderInTarget, name: "renderInTarget");
					disableLight = s.Serialize<int>(disableLight, name: "disableLight");
					disableShadow = s.Serialize<int>(disableShadow, name: "disableShadow");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
					AlphaInit = s.Serialize<float>(AlphaInit, name: "AlphaInit");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
						ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
					}
					PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
					colorComputerTagId = s.Serialize<uint>(colorComputerTagId, name: "colorComputerTagId");
					renderInTarget = s.Serialize<bool>(renderInTarget, name: "renderInTarget");
					disableLight = s.Serialize<int>(disableLight, name: "disableLight");
					disableShadow = s.Serialize<int>(disableShadow, name: "disableShadow");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
					AlphaInit = s.Serialize<float>(AlphaInit, name: "AlphaInit");
					highlightFrontLightBrightness = s.Serialize<float>(highlightFrontLightBrightness, name: "highlightFrontLightBrightness");
					highlightOutlineColor = s.SerializeObject<Color>(highlightOutlineColor, name: "highlightOutlineColor");
					highlightOutlineWidth = s.Serialize<float>(highlightOutlineWidth, name: "highlightOutlineWidth");
				}
			}
		}
		public override uint? ClassCRC => 0x804757FE;
	}
}

