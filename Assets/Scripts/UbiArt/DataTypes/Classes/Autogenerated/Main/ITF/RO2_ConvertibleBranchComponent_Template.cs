namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_ConvertibleBranchComponent_Template : RO2_BezierBranchComponent_Template {
		public float width = 1f;
		public bool attachToEnd = true;
		public float tileLength = 1f;
		public CListO<SpriteBone> tileBones;
		public float endLength = 1f;
		public CListO<SpriteBone> endBones;
		public Path amvPath;
		public GFXMaterialSerializable amvMaterial;
		public float zOffset;
		public float scaleFactor = 1f;
		public bool convertFromEnd = true;
		public float conversionSpeed = 1f;
		public Path convertedGameMaterial;
		public float conversionOffset;
		public float conversionOverlap;
		public CListO<ConvertibleElement_Template> elementTypes;
		public float triggerDelay = -1f;
		public float zSegmentation = 0.25f;
		public bool drawDebug;
		public bool drawDebugAnims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd", options: CSerializerObject.Options.BoolAsByte);
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CListO<SpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CListO<SpriteBone>>(endBones, name: "endBones");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				amvMaterial = s.SerializeObject<GFXMaterialSerializable>(amvMaterial, name: "amvMaterial");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				scaleFactor = s.Serialize<float>(scaleFactor, name: "scaleFactor");
				convertFromEnd = s.Serialize<bool>(convertFromEnd, name: "convertFromEnd", options: CSerializerObject.Options.BoolAsByte);
				conversionSpeed = s.Serialize<float>(conversionSpeed, name: "conversionSpeed");
				convertedGameMaterial = s.SerializeObject<Path>(convertedGameMaterial, name: "convertedGameMaterial");
				conversionOffset = s.Serialize<float>(conversionOffset, name: "conversionOffset");
				conversionOverlap = s.Serialize<float>(conversionOverlap, name: "conversionOverlap");
				elementTypes = s.SerializeObject<CListO<ConvertibleElement_Template>>(elementTypes, name: "elementTypes");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug", options: CSerializerObject.Options.BoolAsByte);
				drawDebugAnims = s.Serialize<bool>(drawDebugAnims, name: "drawDebugAnims", options: CSerializerObject.Options.BoolAsByte);
			} else {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CListO<SpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CListO<SpriteBone>>(endBones, name: "endBones");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				amvMaterial = s.SerializeObject<GFXMaterialSerializable>(amvMaterial, name: "amvMaterial");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				scaleFactor = s.Serialize<float>(scaleFactor, name: "scaleFactor");
				convertFromEnd = s.Serialize<bool>(convertFromEnd, name: "convertFromEnd");
				conversionSpeed = s.Serialize<float>(conversionSpeed, name: "conversionSpeed");
				convertedGameMaterial = s.SerializeObject<Path>(convertedGameMaterial, name: "convertedGameMaterial");
				conversionOffset = s.Serialize<float>(conversionOffset, name: "conversionOffset");
				conversionOverlap = s.Serialize<float>(conversionOverlap, name: "conversionOverlap");
				elementTypes = s.SerializeObject<CListO<ConvertibleElement_Template>>(elementTypes, name: "elementTypes");
				triggerDelay = s.Serialize<float>(triggerDelay, name: "triggerDelay");
				zSegmentation = s.Serialize<float>(zSegmentation, name: "zSegmentation");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
				drawDebugAnims = s.Serialize<bool>(drawDebugAnims, name: "drawDebugAnims");
			}
		}
		public override uint? ClassCRC => 0xA2EB4EEC;
	}
}

