using UnityEngine;

namespace UbiArt.ITF {
	public partial class GraphicComponent_Template : ActorComponent_Template {
		[Serialize("patchLevel"                   )] public uint patchLevel;
		[Serialize("patchHLevel"                  )] public uint patchHLevel;
		[Serialize("patchVLevel"                  )] public uint patchVLevel;
		[Serialize("visualAABB"                   )] public AABB visualAABB;
		[Serialize("renderintarget"               )] public bool renderintarget;
		[Serialize("posOffset"                    )] public Vector2 posOffset;
		[Serialize("depthOffset"                  )] public float depthOffset;
		[Serialize("blendmode"                    )] public GFX_BLEND blendmode;
		[Serialize("materialtype"                 )] public GFX_MAT materialtype;
		[Serialize("selfIllumColor"               )] public Color selfIllumColor;
		[Serialize("disableLight"                 )] public bool disableLight;
		[Serialize("forceDisableLight"            )] public bool forceDisableLight;
		[Serialize("useShadow"                    )] public bool useShadow;
		[Serialize("useNoColShadow"               )] public bool useNoColShadow;
		[Serialize("useRootBone"                  )] public bool useRootBone;
		[Serialize("shadowSize"                   )] public Vector2 shadowSize;
		[Serialize("shadowTextureFile"            )] public Path shadowTextureFile;
		[Serialize("shadowMaterial"               )] public GFXMaterialSerializable shadowMaterial;
		[Serialize("shadowAttenuation"            )] public float shadowAttenuation;
		[Serialize("shadowDist"                   )] public float shadowDist;
		[Serialize("shadowOffsetPos"              )] public Vector3 shadowOffsetPos;
		[Serialize("angleLimit"                   )] public float angleLimit;
		[Serialize("curveSize0"                   )] public float curveSize0;
		[Serialize("curveSize1"                   )] public float curveSize1;
		[Serialize("curveSizePower"               )] public float curveSizePower;
		[Serialize("highlightPeriod"              )] public float highlightPeriod;
		[Serialize("highlightAmplitude"           )] public float highlightAmplitude;
		[Serialize("highlightOutlineColor"        )] public Color highlightOutlineColor;
		[Serialize("highlightFrontLightBrightness")] public float highlightFrontLightBrightness;
		[Serialize("highlightOutlineWidth"        )] public float highlightOutlineWidth;
		[Serialize("angleOffset"                  )] public Angle angleOffset;
		[Serialize("blendmode"                    )] public Enum_blendmode blendmode;
		[Serialize("materialtype"                 )] public Enum_materialtype materialtype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(materialtype));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(forceDisableLight));
				SerializeField(s, nameof(useShadow));
				SerializeField(s, nameof(useRootBone));
				SerializeField(s, nameof(shadowSize));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(shadowTextureFile));
				}
				SerializeField(s, nameof(shadowMaterial));
				SerializeField(s, nameof(shadowAttenuation));
				SerializeField(s, nameof(shadowDist));
				SerializeField(s, nameof(shadowOffsetPos));
				SerializeField(s, nameof(angleLimit));
			} else {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(materialtype));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(forceDisableLight));
				SerializeField(s, nameof(useShadow));
				SerializeField(s, nameof(useNoColShadow));
				SerializeField(s, nameof(useRootBone));
				SerializeField(s, nameof(shadowSize));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(shadowTextureFile));
				}
				SerializeField(s, nameof(shadowMaterial));
				SerializeField(s, nameof(shadowAttenuation));
				SerializeField(s, nameof(shadowDist));
				SerializeField(s, nameof(shadowOffsetPos));
				SerializeField(s, nameof(angleLimit));
				SerializeField(s, nameof(curveSize0));
				SerializeField(s, nameof(curveSize1));
				SerializeField(s, nameof(curveSizePower));
				SerializeField(s, nameof(highlightPeriod));
				SerializeField(s, nameof(highlightAmplitude));
				SerializeField(s, nameof(highlightOutlineColor));
				SerializeField(s, nameof(highlightFrontLightBrightness));
				SerializeField(s, nameof(highlightOutlineWidth));
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
		public enum Enum_blendmode {
			[Serialize("Value_0" )] Value_0 = 0,
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
			[Serialize("Value_21")] Value_21 = 21,
		}
		public enum Enum_materialtype {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_12")] Value_12 = 12,
		}
		public override uint? ClassCRC => 0x71471FD2;
	}
}

