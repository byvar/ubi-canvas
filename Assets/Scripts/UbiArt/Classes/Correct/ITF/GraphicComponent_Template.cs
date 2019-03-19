using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class GraphicComponent_Template : ActorComponent_Template {
		[Serialize("patchLevel"                   )] public uint patchLevel;
		[Serialize("patchHLevel"                  )] public uint patchHLevel;
		[Serialize("patchVLevel"                  )] public uint patchVLevel;
		[Serialize("visualAABB"                   )] public AABB visualAABB;
		[Serialize("renderintarget"               )] public bool renderintarget;
		[Serialize("posOffset"                    )] public Vector2 posOffset;
		[Serialize("depthOffset"                  )] public float depthOffset;
		[Serialize("angleOffset"                  )] public Angle angleOffset;
		[Serialize("blendmode"                    )] public GFX_BLEND blendmode;
		[Serialize("blendmode"                    )] public GFX_BLEND2 blendmode2;
		[Serialize("materialtype"                 )] public GFX_MAT materialtype;
		[Serialize("materialtype"                 )] public GFX_MAT2 materialtype2;
		[Serialize("materialtype"                 )] public GFX_MAT3 materialtype3;
		[Serialize("materialtype"                 )] public GFX_MAT4 materialtype4;
		[Serialize("selfIllumColor"               )] public Color selfIllumColor;
		[Serialize("disableLight"                 )] public bool disableLight;
		[Serialize("forceDisableLight"            )] public bool forceDisableLight;
		[Serialize("useShadow"                    )] public bool useShadow;
		[Serialize("useNoColShadow"               )] public bool useNoColShadow;
		[Serialize("useRootBone"                  )] public bool useRootBone;
		[Serialize("shadowUseBase"                )] public bool shadowUseBase;
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
		[Serialize("shadowUnderBone"              )] public StringID shadowUnderBone;
		[Serialize("float__64"                    )] public float float__64;
		[Serialize("float__65"                    )] public float float__65;
		[Serialize("float__66"                    )] public float float__66;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(forceDisableLight));
				SerializeField(s, nameof(useShadow));
				SerializeField(s, nameof(useRootBone));
				SerializeField(s, nameof(shadowTextureFile));
				SerializeField(s, nameof(shadowSize));
				SerializeField(s, nameof(shadowAttenuation));
				SerializeField(s, nameof(shadowDist));
				SerializeField(s, nameof(shadowOffsetPos));
				SerializeField(s, nameof(angleLimit));
				SerializeField(s, nameof(blendmode2));
				SerializeField(s, nameof(materialtype2));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(materialtype3));
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
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget), boolAsByte: true);
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(materialtype3));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(disableLight), boolAsByte: true);
				SerializeField(s, nameof(forceDisableLight), boolAsByte: true);
				SerializeField(s, nameof(useShadow), boolAsByte: true);
				SerializeField(s, nameof(shadowUseBase), boolAsByte: true);
				SerializeField(s, nameof(shadowUnderBone));
				SerializeField(s, nameof(shadowSize));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(shadowTextureFile));
				}
				SerializeField(s, nameof(shadowMaterial));
				SerializeField(s, nameof(shadowAttenuation));
				SerializeField(s, nameof(shadowDist));
				SerializeField(s, nameof(shadowOffsetPos));
				SerializeField(s, nameof(angleLimit));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(patchLevel));
				SerializeField(s, nameof(patchHLevel));
				SerializeField(s, nameof(patchVLevel));
				SerializeField(s, nameof(visualAABB));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(posOffset));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(materialtype4));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(forceDisableLight));
				SerializeField(s, nameof(useShadow));
				SerializeField(s, nameof(useNoColShadow));
				SerializeField(s, nameof(useRootBone));
				SerializeField(s, nameof(shadowUnderBone));
				SerializeField(s, nameof(shadowSize));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(shadowTextureFile));
				}
				SerializeField(s, nameof(shadowMaterial));
				SerializeField(s, nameof(shadowAttenuation));
				SerializeField(s, nameof(shadowDist));
				SerializeField(s, nameof(shadowOffsetPos));
				SerializeField(s, nameof(angleLimit));
				SerializeField(s, nameof(float__64));
				SerializeField(s, nameof(float__65));
				SerializeField(s, nameof(float__66));
			} else {
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

