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
		[Serialize("blendmode"         )] public GFX_BLEND blendmode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(nbFrames));
				SerializeField(s, nameof(trailFaidingTime));
				SerializeField(s, nameof(thicknessBegin));
				SerializeField(s, nameof(thicknessEnd));
				SerializeField(s, nameof(alphaBegin));
				SerializeField(s, nameof(alphaEnd));
				SerializeField(s, nameof(trailBlending));
				SerializeField(s, nameof(fadeLength));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(attachBone));
			} else if(Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(nbFrames));
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

