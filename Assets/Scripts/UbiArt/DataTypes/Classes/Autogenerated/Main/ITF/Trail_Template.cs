using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class Trail_Template : CSerializable {
		public Path texture;
		public GFXMaterialSerializable material;
		public uint nbFrames;
		public uint fixTrailLenght;
		public float trailFaidingTime;
		public float thicknessBegin;
		public float thicknessEnd;
		public float alphaBegin;
		public float alphaEnd;
		public float trailBlending;
		public float fadeLength;
		public float tesselateMaxLength;
		public float tesselateMinLength;
		public Color color;
		public StringID attachBone;
		public GFX_BLEND blendmode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				nbFrames = s.Serialize<uint>(nbFrames, name: "nbFrames");
				trailFaidingTime = s.Serialize<float>(trailFaidingTime, name: "trailFaidingTime");
				thicknessBegin = s.Serialize<float>(thicknessBegin, name: "thicknessBegin");
				thicknessEnd = s.Serialize<float>(thicknessEnd, name: "thicknessEnd");
				alphaBegin = s.Serialize<float>(alphaBegin, name: "alphaBegin");
				alphaEnd = s.Serialize<float>(alphaEnd, name: "alphaEnd");
				trailBlending = s.Serialize<float>(trailBlending, name: "trailBlending");
				fadeLength = s.Serialize<float>(fadeLength, name: "fadeLength");
				blendmode = s.Serialize<GFX_BLEND>(blendmode, name: "blendmode");
				color = s.SerializeObject<Color>(color, name: "color");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
			} else if(s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				nbFrames = s.Serialize<uint>(nbFrames, name: "nbFrames");
				trailFaidingTime = s.Serialize<float>(trailFaidingTime, name: "trailFaidingTime");
				thicknessBegin = s.Serialize<float>(thicknessBegin, name: "thicknessBegin");
				thicknessEnd = s.Serialize<float>(thicknessEnd, name: "thicknessEnd");
				alphaBegin = s.Serialize<float>(alphaBegin, name: "alphaBegin");
				alphaEnd = s.Serialize<float>(alphaEnd, name: "alphaEnd");
				trailBlending = s.Serialize<float>(trailBlending, name: "trailBlending");
				fadeLength = s.Serialize<float>(fadeLength, name: "fadeLength");
				tesselateMaxLength = s.Serialize<float>(tesselateMaxLength, name: "tesselateMaxLength");
				tesselateMinLength = s.Serialize<float>(tesselateMinLength, name: "tesselateMinLength");
				color = s.SerializeObject<Color>(color, name: "color");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				nbFrames = s.Serialize<uint>(nbFrames, name: "nbFrames");
				fixTrailLenght = s.Serialize<uint>(fixTrailLenght, name: "fixTrailLenght");
				trailFaidingTime = s.Serialize<float>(trailFaidingTime, name: "trailFaidingTime");
				thicknessBegin = s.Serialize<float>(thicknessBegin, name: "thicknessBegin");
				thicknessEnd = s.Serialize<float>(thicknessEnd, name: "thicknessEnd");
				alphaBegin = s.Serialize<float>(alphaBegin, name: "alphaBegin");
				alphaEnd = s.Serialize<float>(alphaEnd, name: "alphaEnd");
				trailBlending = s.Serialize<float>(trailBlending, name: "trailBlending");
				fadeLength = s.Serialize<float>(fadeLength, name: "fadeLength");
				tesselateMaxLength = s.Serialize<float>(tesselateMaxLength, name: "tesselateMaxLength");
				tesselateMinLength = s.Serialize<float>(tesselateMinLength, name: "tesselateMinLength");
				color = s.SerializeObject<Color>(color, name: "color");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
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
		}
	}
}

