using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ForceFieldComponent_Template : GraphicComponent_Template {
		[Serialize("softCollisionRadius"                 )] public float softCollisionRadius;
		[Serialize("bounceRadius"                        )] public float bounceRadius;
		[Serialize("linkEvents"                          )] public Placeholder linkEvents;
		[Serialize("softCollisionExitSpeed"              )] public float softCollisionExitSpeed;
		[Serialize("softCollisionExitForce"              )] public float softCollisionExitForce;
		[Serialize("lockedFx"                            )] public StringID lockedFx;
		[Serialize("patchCenterWidth"                    )] public float patchCenterWidth;
		[Serialize("patchCircleWidth"                    )] public float patchCircleWidth;
		[Serialize("patchTargetWidth"                    )] public float patchTargetWidth;
		[Serialize("patchCircleTangeantRotationOffset"   )] public Angle patchCircleTangeantRotationOffset;
		[Serialize("patchTargetTangeantRotationOffset"   )] public Angle patchTargetTangeantRotationOffset;
		[Serialize("patchCircleTangeantRotationFrequency")] public float patchCircleTangeantRotationFrequency;
		[Serialize("patchTargetTangeantRotationFrequency")] public float patchTargetTangeantRotationFrequency;
		[Serialize("texture"                             )] public Path texture;
		[Serialize("patchTileLength"                     )] public float patchTileLength;
		[Serialize("patchScrollSpeed"                    )] public float patchScrollSpeed;
		[Serialize("idleAnim"                            )] public StringID idleAnim;
		[Serialize("fadeAnim"                            )] public StringID fadeAnim;
		[Serialize("tesselationLength"                   )] public float tesselationLength;
		[Serialize("patchMidPointOffset"                 )] public float patchMidPointOffset;
		[Serialize("patchMidPointPercent"                )] public float patchMidPointPercent;
		[Serialize("patchCenterOffset"                   )] public float patchCenterOffset;
		[Serialize("blendmode"                           )] public GFX_BLEND blendmode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(softCollisionRadius));
			SerializeField(s, nameof(bounceRadius));
			SerializeField(s, nameof(linkEvents));
			SerializeField(s, nameof(softCollisionExitSpeed));
			SerializeField(s, nameof(softCollisionExitForce));
			SerializeField(s, nameof(lockedFx));
			SerializeField(s, nameof(patchCenterWidth));
			SerializeField(s, nameof(patchCircleWidth));
			SerializeField(s, nameof(patchTargetWidth));
			SerializeField(s, nameof(patchCircleTangeantRotationOffset));
			SerializeField(s, nameof(patchTargetTangeantRotationOffset));
			SerializeField(s, nameof(patchCircleTangeantRotationFrequency));
			SerializeField(s, nameof(patchTargetTangeantRotationFrequency));
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(patchTileLength));
			SerializeField(s, nameof(patchScrollSpeed));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(fadeAnim));
			SerializeField(s, nameof(tesselationLength));
			SerializeField(s, nameof(patchMidPointOffset));
			SerializeField(s, nameof(patchMidPointPercent));
			SerializeField(s, nameof(patchCenterOffset));
			SerializeField(s, nameof(blendmode));
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
		public override uint? ClassCRC => 0x35A6B61A;
	}
}

