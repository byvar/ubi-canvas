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
		[Serialize("patchBlendMode"                      )] public GFX_BLEND2 patchBlendMode;
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
		
		public override uint? ClassCRC => 0x0187DB02;
	}
}

