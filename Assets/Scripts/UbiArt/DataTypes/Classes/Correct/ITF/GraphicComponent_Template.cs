namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class GraphicComponent_Template : ActorComponent_Template {
		public uint patchLevel;
		public uint patchHLevel = 2;
		public uint patchVLevel = 2;
		public AABB visualAABB;
		public bool renderintarget;
		public Vec2d posOffset;
		public float depthOffset;
		public Angle angleOffset;
		public GFX_BLEND blendmode = GFX_BLEND.ALPHA;
		public GFX_BLEND2 blendmode2 = GFX_BLEND2.ALPHA;
		public GFX_MAT materialtype;
		public GFX_MAT2 materialtype2;
		public GFX_MAT3 materialtype3;
		public GFX_MAT4 materialtype4;
		public Color selfIllumColor;
		public bool disableLight;
		public bool forceDisableLight;
		public bool useShadow;
		public bool useNoColShadow;
		public bool useRootBone;
		public bool shadowUseBase;
		public Vec2d shadowSize = new Vec2d(1.8f, 0.3f);
		public Path shadowTextureFile;
		public GFXMaterialSerializable shadowMaterial;
		public float shadowAttenuation = 1f;
		public float shadowDist = 4f;
		public Vec3d shadowOffsetPos;
		public float angleLimit;
		public float curveSize0;
		public float curveSize1 = 1f;
		public float curveSizePower = 1f;
		public float highlightPeriod = 1f;
		public float highlightAmplitude = 0.21f;
		public Color highlightOutlineColor = Color.White;
		public float highlightFrontLightBrightness = 0.25f;
		public float highlightOutlineWidth = 4f;
		public StringID shadowUnderBone;
		public float float__64;
		public float float__65;
		public float float__66;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (this is FxBankComponent_Template || this is ParticleGeneratorComponent_Template || this is ProceduralSoftPlatformComponent_Template) return;
				patchLevel = s.Serialize<uint>(patchLevel, name: "patchLevel");
				patchHLevel = s.Serialize<uint>(patchHLevel, name: "patchHLevel");
				patchVLevel = s.Serialize<uint>(patchVLevel, name: "patchVLevel");
				visualAABB = s.SerializeObject<AABB>(visualAABB, name: "visualAABB");
				renderintarget = s.Serialize<bool>(renderintarget, name: "renderintarget");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				selfIllumColor = s.SerializeObject<Color>(selfIllumColor, name: "selfIllumColor");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				forceDisableLight = s.Serialize<bool>(forceDisableLight, name: "forceDisableLight");
				useShadow = s.Serialize<bool>(useShadow, name: "useShadow");
				useRootBone = s.Serialize<bool>(useRootBone, name: "useRootBone");
				shadowTextureFile = s.SerializeObject<Path>(shadowTextureFile, name: "shadowTextureFile");
				shadowSize = s.SerializeObject<Vec2d>(shadowSize, name: "shadowSize");
				shadowAttenuation = s.Serialize<float>(shadowAttenuation, name: "shadowAttenuation");
				shadowDist = s.Serialize<float>(shadowDist, name: "shadowDist");
				shadowOffsetPos = s.SerializeObject<Vec3d>(shadowOffsetPos, name: "shadowOffsetPos");
				angleLimit = s.Serialize<float>(angleLimit, name: "angleLimit");
				blendmode2 = s.Serialize<GFX_BLEND2>(blendmode2, name: "blendmode");
				materialtype2 = s.Serialize<GFX_MAT2>(materialtype2, name: "materialtype");
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.Settings.platform == Settings.Platform.Vita && this is RO2_RopeComponent_Template) return;
				patchLevel = s.Serialize<uint>(patchLevel, name: "patchLevel");
				patchHLevel = s.Serialize<uint>(patchHLevel, name: "patchHLevel");
				patchVLevel = s.Serialize<uint>(patchVLevel, name: "patchVLevel");
				visualAABB = s.SerializeObject<AABB>(visualAABB, name: "visualAABB");
				renderintarget = s.Serialize<bool>(renderintarget, name: "renderintarget");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				blendmode = s.Serialize<GFX_BLEND>(blendmode, name: "blendmode");
				materialtype3 = s.Serialize<GFX_MAT3>(materialtype3, name: "materialtype");
				selfIllumColor = s.SerializeObject<Color>(selfIllumColor, name: "selfIllumColor");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				forceDisableLight = s.Serialize<bool>(forceDisableLight, name: "forceDisableLight");
				useShadow = s.Serialize<bool>(useShadow, name: "useShadow");
				useRootBone = s.Serialize<bool>(useRootBone, name: "useRootBone");
				shadowSize = s.SerializeObject<Vec2d>(shadowSize, name: "shadowSize");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					shadowTextureFile = s.SerializeObject<Path>(shadowTextureFile, name: "shadowTextureFile");
				}
				shadowMaterial = s.SerializeObject<GFXMaterialSerializable>(shadowMaterial, name: "shadowMaterial");
				shadowAttenuation = s.Serialize<float>(shadowAttenuation, name: "shadowAttenuation");
				shadowDist = s.Serialize<float>(shadowDist, name: "shadowDist");
				shadowOffsetPos = s.SerializeObject<Vec3d>(shadowOffsetPos, name: "shadowOffsetPos");
				angleLimit = s.Serialize<float>(angleLimit, name: "angleLimit");
			} else if (s.Settings.game == Settings.Game.COL) {
				patchLevel = s.Serialize<uint>(patchLevel, name: "patchLevel");
				patchHLevel = s.Serialize<uint>(patchHLevel, name: "patchHLevel");
				patchVLevel = s.Serialize<uint>(patchVLevel, name: "patchVLevel");
				visualAABB = s.SerializeObject<AABB>(visualAABB, name: "visualAABB");
				renderintarget = s.Serialize<bool>(renderintarget, name: "renderintarget", options: CSerializerObject.Options.BoolAsByte);
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				blendmode = s.Serialize<GFX_BLEND>(blendmode, name: "blendmode");
				materialtype3 = s.Serialize<GFX_MAT3>(materialtype3, name: "materialtype");
				selfIllumColor = s.SerializeObject<Color>(selfIllumColor, name: "selfIllumColor");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight", options: CSerializerObject.Options.BoolAsByte);
				forceDisableLight = s.Serialize<bool>(forceDisableLight, name: "forceDisableLight", options: CSerializerObject.Options.BoolAsByte);
				useShadow = s.Serialize<bool>(useShadow, name: "useShadow", options: CSerializerObject.Options.BoolAsByte);
				shadowUseBase = s.Serialize<bool>(shadowUseBase, name: "shadowUseBase", options: CSerializerObject.Options.BoolAsByte);
				shadowUnderBone = s.SerializeObject<StringID>(shadowUnderBone, name: "shadowUnderBone");
				shadowSize = s.SerializeObject<Vec2d>(shadowSize, name: "shadowSize");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					shadowTextureFile = s.SerializeObject<Path>(shadowTextureFile, name: "shadowTextureFile");
				}
				shadowMaterial = s.SerializeObject<GFXMaterialSerializable>(shadowMaterial, name: "shadowMaterial");
				shadowAttenuation = s.Serialize<float>(shadowAttenuation, name: "shadowAttenuation");
				shadowDist = s.Serialize<float>(shadowDist, name: "shadowDist");
				shadowOffsetPos = s.SerializeObject<Vec3d>(shadowOffsetPos, name: "shadowOffsetPos");
				angleLimit = s.Serialize<float>(angleLimit, name: "angleLimit");
			} else if (s.Settings.game == Settings.Game.VH) {
				patchLevel = s.Serialize<uint>(patchLevel, name: "patchLevel");
				patchHLevel = s.Serialize<uint>(patchHLevel, name: "patchHLevel");
				patchVLevel = s.Serialize<uint>(patchVLevel, name: "patchVLevel");
				visualAABB = s.SerializeObject<AABB>(visualAABB, name: "visualAABB");
				renderintarget = s.Serialize<bool>(renderintarget, name: "renderintarget");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				blendmode = s.Serialize<GFX_BLEND>(blendmode, name: "blendmode");
				materialtype4 = s.Serialize<GFX_MAT4>(materialtype4, name: "materialtype");
				selfIllumColor = s.SerializeObject<Color>(selfIllumColor, name: "selfIllumColor");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				forceDisableLight = s.Serialize<bool>(forceDisableLight, name: "forceDisableLight");
				useShadow = s.Serialize<bool>(useShadow, name: "useShadow");
				useNoColShadow = s.Serialize<bool>(useNoColShadow, name: "useNoColShadow");
				useRootBone = s.Serialize<bool>(useRootBone, name: "useRootBone");
				shadowUnderBone = s.SerializeObject<StringID>(shadowUnderBone, name: "shadowUnderBone");
				shadowSize = s.SerializeObject<Vec2d>(shadowSize, name: "shadowSize");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					shadowTextureFile = s.SerializeObject<Path>(shadowTextureFile, name: "shadowTextureFile");
				}
				shadowMaterial = s.SerializeObject<GFXMaterialSerializable>(shadowMaterial, name: "shadowMaterial");
				shadowAttenuation = s.Serialize<float>(shadowAttenuation, name: "shadowAttenuation");
				shadowDist = s.Serialize<float>(shadowDist, name: "shadowDist");
				shadowOffsetPos = s.SerializeObject<Vec3d>(shadowOffsetPos, name: "shadowOffsetPos");
				angleLimit = s.Serialize<float>(angleLimit, name: "angleLimit");
				float__64 = s.Serialize<float>(float__64, name: "float__64");
				float__65 = s.Serialize<float>(float__65, name: "float__65");
				float__66 = s.Serialize<float>(float__66, name: "float__66");
			} else {
				patchLevel = s.Serialize<uint>(patchLevel, name: "patchLevel");
				patchHLevel = s.Serialize<uint>(patchHLevel, name: "patchHLevel");
				patchVLevel = s.Serialize<uint>(patchVLevel, name: "patchVLevel");
				visualAABB = s.SerializeObject<AABB>(visualAABB, name: "visualAABB");
				renderintarget = s.Serialize<bool>(renderintarget, name: "renderintarget");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				blendmode = s.Serialize<GFX_BLEND>(blendmode, name: "blendmode");
				materialtype = s.Serialize<GFX_MAT>(materialtype, name: "materialtype");
				selfIllumColor = s.SerializeObject<Color>(selfIllumColor, name: "selfIllumColor");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				forceDisableLight = s.Serialize<bool>(forceDisableLight, name: "forceDisableLight");
				useShadow = s.Serialize<bool>(useShadow, name: "useShadow");
				useNoColShadow = s.Serialize<bool>(useNoColShadow, name: "useNoColShadow");
				useRootBone = s.Serialize<bool>(useRootBone, name: "useRootBone");
				shadowSize = s.SerializeObject<Vec2d>(shadowSize, name: "shadowSize");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					shadowTextureFile = s.SerializeObject<Path>(shadowTextureFile, name: "shadowTextureFile");
				}
				shadowMaterial = s.SerializeObject<GFXMaterialSerializable>(shadowMaterial, name: "shadowMaterial");
				shadowAttenuation = s.Serialize<float>(shadowAttenuation, name: "shadowAttenuation");
				shadowDist = s.Serialize<float>(shadowDist, name: "shadowDist");
				shadowOffsetPos = s.SerializeObject<Vec3d>(shadowOffsetPos, name: "shadowOffsetPos");
				angleLimit = s.Serialize<float>(angleLimit, name: "angleLimit");
				curveSize0 = s.Serialize<float>(curveSize0, name: "curveSize0");
				curveSize1 = s.Serialize<float>(curveSize1, name: "curveSize1");
				curveSizePower = s.Serialize<float>(curveSizePower, name: "curveSizePower");
				highlightPeriod = s.Serialize<float>(highlightPeriod, name: "highlightPeriod");
				highlightAmplitude = s.Serialize<float>(highlightAmplitude, name: "highlightAmplitude");
				highlightOutlineColor = s.SerializeObject<Color>(highlightOutlineColor, name: "highlightOutlineColor");
				highlightFrontLightBrightness = s.Serialize<float>(highlightFrontLightBrightness, name: "highlightFrontLightBrightness");
				highlightOutlineWidth = s.Serialize<float>(highlightOutlineWidth, name: "highlightOutlineWidth");
			}
		}
		public enum GFX_BLEND {
			[Serialize("GFX_BLEND_UNKNOWN"          )] UNKNOWN = 0,
			[Serialize("GFX_BLEND_COPY"             )] COPY = 1,
			[Serialize("GFX_BLEND_ALPHA"            )] ALPHA = 2,
			[Serialize("GFX_BLEND_ALPHAPREMULT"     )] ALPHAPREMULT = 3,
			[Serialize("GFX_BLEND_ALPHADEST"        )] ALPHADEST = 4,
			[Serialize("GFX_BLEND_ALPHADESTPREMULT" )] ALPHADESTPREMULT = 5,
			[Serialize("GFX_BLEND_ADD"              )] ADD = 6,
			[Serialize("GFX_BLEND_ADDALPHA"         )] ADDALPHA = 7,
			[Serialize("GFX_BLEND_SUBALPHA"         )] SUBALPHA = 8,
			[Serialize("GFX_BLEND_SUB"              )] SUB = 9,
			[Serialize("GFX_BLEND_MUL"              )] MUL = 10,
			[Serialize("GFX_BLEND_ALPHAMUL"         )] ALPHAMUL = 11,
			[Serialize("GFX_BLEND_IALPHAMUL"        )] IALPHAMUL = 12,
			[Serialize("GFX_BLEND_IALPHA"           )] IALPHA = 13,
			[Serialize("GFX_BLEND_IALPHAPREMULT"    )] IALPHAPREMULT = 14,
			[Serialize("GFX_BLEND_IALPHADEST"       )] IALPHADEST = 15,
			[Serialize("GFX_BLEND_IALPHADESTPREMULT")] IALPHADESTPREMULT = 16,
			[Serialize("GFX_BLEND_MUL2X"            )] MUL2X = 17,
			[Serialize("GFX_BLEND_ALPHATOCOLOR"     )] ALPHATOCOLOR = 18,
			[Serialize("GFX_BLEND_IALPHATOCOLOR"    )] IALPHATOCOLOR = 19,
			[Serialize("GFX_BLEND_SCREEN"           )] SCREEN = 21,
		}
		public enum GFX_MAT {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
		}
		public enum GFX_MAT2 {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
		}
		public enum GFX_BLEND2 {
			[Serialize("GFX_BLEND_UNKNOWN"          )] UNKNOWN = 0,
			[Serialize("GFX_BLEND_COPY"             )] COPY = 1,
			[Serialize("GFX_BLEND_ALPHA"            )] ALPHA = 2,
			[Serialize("GFX_BLEND_ALPHAPREMULT"     )] ALPHAPREMULT = 3,
			[Serialize("GFX_BLEND_ALPHADEST"        )] ALPHADEST = 4,
			[Serialize("GFX_BLEND_ALPHADESTPREMULT" )] ALPHADESTPREMULT = 5,
			[Serialize("GFX_BLEND_ADD"              )] ADD = 6,
			[Serialize("GFX_BLEND_ADDALPHA"         )] ADDALPHA = 7,
			[Serialize("GFX_BLEND_SUBALPHA"         )] SUBALPHA = 8,
			[Serialize("GFX_BLEND_SUB"              )] SUB = 9,
			[Serialize("GFX_BLEND_MUL"              )] MUL = 10,
			[Serialize("GFX_BLEND_ALPHAMUL"         )] ALPHAMUL = 11,
			[Serialize("GFX_BLEND_IALPHAMUL"        )] IALPHAMUL = 12,
			[Serialize("GFX_BLEND_IALPHA"           )] IALPHA = 13,
			[Serialize("GFX_BLEND_IALPHAPREMULT"    )] IALPHAPREMULT = 14,
			[Serialize("GFX_BLEND_IALPHADEST"       )] IALPHADEST = 15,
			[Serialize("GFX_BLEND_IALPHADESTPREMULT")] IALPHADESTPREMULT = 16,
			[Serialize("GFX_BLEND_MUL2X"            )] MUL2X = 17,
			[Serialize("GFX_BLEND_ALPHATOCOLOR"     )] ALPHATOCOLOR = 18,
			[Serialize("GFX_BLEND_IALPHATOCOLOR"    )] IALPHATOCOLOR = 19,
		}
		public enum GFX_MAT3 {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
			[Serialize("Value_12")] Value_12 = 12,
		}
		public enum GFX_MAT4 {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
		}
		public override uint? ClassCRC => 0x71471FD2;
	}
}

