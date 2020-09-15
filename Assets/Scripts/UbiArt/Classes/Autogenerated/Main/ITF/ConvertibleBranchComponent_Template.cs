using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class ConvertibleBranchComponent_Template : BezierBranchComponent_Template {
		public float width;
		public bool attachToEnd;
		public float tileLength;
		public CList<SpriteBone> tileBones;
		public float endLength;
		public CList<SpriteBone> endBones;
		public Path amvPath;
		public GFXMaterialSerializable amvMaterial;
		public float zOffset;
		public float scaleFactor;
		public bool convertFromEnd;
		public float conversionSpeed;
		public Path convertedGameMaterial;
		public float conversionOffset;
		public float conversionOverlap;
		public CList<ConvertibleElement_Template> elementTypes;
		public float triggerDelay;
		public float zSegmentation;
		public bool drawDebug;
		public bool drawDebugAnims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd", options: CSerializerObject.Options.BoolAsByte);
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CList<SpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CList<SpriteBone>>(endBones, name: "endBones");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				amvMaterial = s.SerializeObject<GFXMaterialSerializable>(amvMaterial, name: "amvMaterial");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				scaleFactor = s.Serialize<float>(scaleFactor, name: "scaleFactor");
				convertFromEnd = s.Serialize<bool>(convertFromEnd, name: "convertFromEnd", options: CSerializerObject.Options.BoolAsByte);
				conversionSpeed = s.Serialize<float>(conversionSpeed, name: "conversionSpeed");
				convertedGameMaterial = s.SerializeObject<Path>(convertedGameMaterial, name: "convertedGameMaterial");
				conversionOffset = s.Serialize<float>(conversionOffset, name: "conversionOffset");
				conversionOverlap = s.Serialize<float>(conversionOverlap, name: "conversionOverlap");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug", options: CSerializerObject.Options.BoolAsByte);
				drawDebugAnims = s.Serialize<bool>(drawDebugAnims, name: "drawDebugAnims", options: CSerializerObject.Options.BoolAsByte);
			} else {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CList<SpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CList<SpriteBone>>(endBones, name: "endBones");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				amvMaterial = s.SerializeObject<GFXMaterialSerializable>(amvMaterial, name: "amvMaterial");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				scaleFactor = s.Serialize<float>(scaleFactor, name: "scaleFactor");
				convertFromEnd = s.Serialize<bool>(convertFromEnd, name: "convertFromEnd");
				conversionSpeed = s.Serialize<float>(conversionSpeed, name: "conversionSpeed");
				convertedGameMaterial = s.SerializeObject<Path>(convertedGameMaterial, name: "convertedGameMaterial");
				conversionOffset = s.Serialize<float>(conversionOffset, name: "conversionOffset");
				conversionOverlap = s.Serialize<float>(conversionOverlap, name: "conversionOverlap");
				elementTypes = s.SerializeObject<CList<ConvertibleElement_Template>>(elementTypes, name: "elementTypes");
				triggerDelay = s.Serialize<float>(triggerDelay, name: "triggerDelay");
				zSegmentation = s.Serialize<float>(zSegmentation, name: "zSegmentation");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
				drawDebugAnims = s.Serialize<bool>(drawDebugAnims, name: "drawDebugAnims");
			}
		}
		public override uint? ClassCRC => 0x6FC0465B;
	}
}

