using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ActivationSequenceVisualComponent_Template : GraphicComponent_Template {
		[Serialize("patchStartRadius"                    )] public float patchStartRadius;
		[Serialize("patchTileLength"                     )] public float patchTileLength;
		[Serialize("patchScrollSpeed"                    )] public float patchScrollSpeed;
		[Serialize("patchStartTangeantRotationOffset"    )] public Angle patchStartTangeantRotationOffset;
		[Serialize("patchTargetTangeantRotationOffset"   )] public Angle patchTargetTangeantRotationOffset;
		[Serialize("patchStartTangeantRotationFrequency" )] public float patchStartTangeantRotationFrequency;
		[Serialize("patchTargetTangeantRotationFrequency")] public float patchTargetTangeantRotationFrequency;
		[Serialize("patchStartWidth"                     )] public float patchStartWidth;
		[Serialize("patchTargetWidth"                    )] public float patchTargetWidth;
		[Serialize("patchTexture"                        )] public Path patchTexture;
		[Serialize("patchBlendMode"                      )] public GFX_BLEND patchBlendMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(patchStartRadius));
			SerializeField(s, nameof(patchTileLength));
			SerializeField(s, nameof(patchScrollSpeed));
			SerializeField(s, nameof(patchStartTangeantRotationOffset));
			SerializeField(s, nameof(patchTargetTangeantRotationOffset));
			SerializeField(s, nameof(patchStartTangeantRotationFrequency));
			SerializeField(s, nameof(patchTargetTangeantRotationFrequency));
			SerializeField(s, nameof(patchStartWidth));
			SerializeField(s, nameof(patchTargetWidth));
			SerializeField(s, nameof(patchTexture));
			SerializeField(s, nameof(patchBlendMode));
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
		public override uint? ClassCRC => 0x0187DB02;
	}
}

