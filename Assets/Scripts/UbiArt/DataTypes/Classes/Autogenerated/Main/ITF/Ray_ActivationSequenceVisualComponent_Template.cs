namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ActivationSequenceVisualComponent_Template : GraphicComponent_Template {
		public float patchStartRadius;
		public float patchTileLength;
		public float patchScrollSpeed;
		public Angle patchStartTangeantRotationOffset;
		public Angle patchTargetTangeantRotationOffset;
		public float patchStartTangeantRotationFrequency;
		public float patchTargetTangeantRotationFrequency;
		public float patchStartWidth;
		public float patchTargetWidth;
		public Path patchTexture;
		public GFX_BLEND2 patchBlendMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			patchStartRadius = s.Serialize<float>(patchStartRadius, name: "patchStartRadius");
			patchTileLength = s.Serialize<float>(patchTileLength, name: "patchTileLength");
			patchScrollSpeed = s.Serialize<float>(patchScrollSpeed, name: "patchScrollSpeed");
			patchStartTangeantRotationOffset = s.SerializeObject<Angle>(patchStartTangeantRotationOffset, name: "patchStartTangeantRotationOffset");
			patchTargetTangeantRotationOffset = s.SerializeObject<Angle>(patchTargetTangeantRotationOffset, name: "patchTargetTangeantRotationOffset");
			patchStartTangeantRotationFrequency = s.Serialize<float>(patchStartTangeantRotationFrequency, name: "patchStartTangeantRotationFrequency");
			patchTargetTangeantRotationFrequency = s.Serialize<float>(patchTargetTangeantRotationFrequency, name: "patchTargetTangeantRotationFrequency");
			patchStartWidth = s.Serialize<float>(patchStartWidth, name: "patchStartWidth");
			patchTargetWidth = s.Serialize<float>(patchTargetWidth, name: "patchTargetWidth");
			patchTexture = s.SerializeObject<Path>(patchTexture, name: "patchTexture");
			patchBlendMode = s.Serialize<GFX_BLEND2>(patchBlendMode, name: "patchBlendMode");
		}
		
		public override uint? ClassCRC => 0x0187DB02;
	}
}

