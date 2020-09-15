using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class RenderBoxComponent_Template : GraphicComponent_Template {
		public bool is2D;
		public bool addBorders;
		public bool useAnimMeshVertex;
		public CList<RenderSingleAnimData> anims;
		public Path texture;
		public GFXMaterialSerializable material;
		public CList<GFXMaterialSerializable> AdditionalMaterials;
		public Path frontTexture;
		public GFXMaterialSerializable frontMaterial;
		public float leftWidth;
		public float rightWidth;
		public float topHeight;
		public float bottomHeight;
		public uint backTopLeftCornerAtlasIndex;
		public uint backTopMiddleCornerAtlasIndex;
		public uint backTopRightCornerAtlasIndex;
		public uint backMiddleLeftCornerAtlasIndex;
		public uint backMiddleMiddleCornerAtlasIndex;
		public uint backMiddleRightCornerAtlasIndex;
		public uint backBottomLeftCornerAtlasIndex;
		public uint backBottomMiddleCornerAtlasIndex;
		public uint backBottomRightCornerAtlasIndex;
		public int backTopLeftCornerAtlasRotate;
		public int backTopMiddleCornerAtlasRotate;
		public int backTopRightCornerAtlasRotate;
		public int backMiddleLeftCornerAtlasRotate;
		public int backMiddleMiddleCornerAtlasRotate;
		public int backMiddleRightCornerAtlasRotate;
		public int backBottomLeftCornerAtlasRotate;
		public int backBottomMiddleCornerAtlasRotate;
		public int backBottomRightCornerAtlasRotate;
		public bool backTopMiddleCornerAtlasTile;
		public bool backMiddleLeftCornerAtlasTile;
		public bool backMiddleRightCornerAtlasTile;
		public bool backBottomMiddleCornerAtlasTile;
		public float xUVToDistance;
		public float yUVToDistance;
		public float zOffset;
		public float dynamicAMVMinimunBorderSize;
		public Vec3d shadowOffset;
		public float shadowAlpha;
		public bool shadowUseFrontTexture;
		public bool posShadowRelative;
		public Vec3d highlightOffset;
		public float highlightAlpha;
		public Vec2d highlightScale;
		public Path highlightTexture;
		public GFXMaterialSerializable highlightMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				is2D = s.Serialize<bool>(is2D, name: "is2D");
				addBorders = s.Serialize<bool>(addBorders, name: "addBorders");
				useAnimMeshVertex = s.Serialize<bool>(useAnimMeshVertex, name: "useAnimMeshVertex");
				anims = s.SerializeObject<CList<RenderSingleAnimData>>(anims, name: "anims");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					frontTexture = s.SerializeObject<Path>(frontTexture, name: "frontTexture");
				}
				frontMaterial = s.SerializeObject<GFXMaterialSerializable>(frontMaterial, name: "frontMaterial");
				leftWidth = s.Serialize<float>(leftWidth, name: "leftWidth");
				rightWidth = s.Serialize<float>(rightWidth, name: "rightWidth");
				topHeight = s.Serialize<float>(topHeight, name: "topHeight");
				bottomHeight = s.Serialize<float>(bottomHeight, name: "bottomHeight");
				backTopLeftCornerAtlasIndex = s.Serialize<uint>(backTopLeftCornerAtlasIndex, name: "backTopLeftCornerAtlasIndex");
				backTopMiddleCornerAtlasIndex = s.Serialize<uint>(backTopMiddleCornerAtlasIndex, name: "backTopMiddleCornerAtlasIndex");
				backTopRightCornerAtlasIndex = s.Serialize<uint>(backTopRightCornerAtlasIndex, name: "backTopRightCornerAtlasIndex");
				backMiddleLeftCornerAtlasIndex = s.Serialize<uint>(backMiddleLeftCornerAtlasIndex, name: "backMiddleLeftCornerAtlasIndex");
				backMiddleMiddleCornerAtlasIndex = s.Serialize<uint>(backMiddleMiddleCornerAtlasIndex, name: "backMiddleMiddleCornerAtlasIndex");
				backMiddleRightCornerAtlasIndex = s.Serialize<uint>(backMiddleRightCornerAtlasIndex, name: "backMiddleRightCornerAtlasIndex");
				backBottomLeftCornerAtlasIndex = s.Serialize<uint>(backBottomLeftCornerAtlasIndex, name: "backBottomLeftCornerAtlasIndex");
				backBottomMiddleCornerAtlasIndex = s.Serialize<uint>(backBottomMiddleCornerAtlasIndex, name: "backBottomMiddleCornerAtlasIndex");
				backBottomRightCornerAtlasIndex = s.Serialize<uint>(backBottomRightCornerAtlasIndex, name: "backBottomRightCornerAtlasIndex");
				backTopLeftCornerAtlasRotate = s.Serialize<int>(backTopLeftCornerAtlasRotate, name: "backTopLeftCornerAtlasRotate");
				backTopMiddleCornerAtlasRotate = s.Serialize<int>(backTopMiddleCornerAtlasRotate, name: "backTopMiddleCornerAtlasRotate");
				backTopRightCornerAtlasRotate = s.Serialize<int>(backTopRightCornerAtlasRotate, name: "backTopRightCornerAtlasRotate");
				backMiddleLeftCornerAtlasRotate = s.Serialize<int>(backMiddleLeftCornerAtlasRotate, name: "backMiddleLeftCornerAtlasRotate");
				backMiddleMiddleCornerAtlasRotate = s.Serialize<int>(backMiddleMiddleCornerAtlasRotate, name: "backMiddleMiddleCornerAtlasRotate");
				backMiddleRightCornerAtlasRotate = s.Serialize<int>(backMiddleRightCornerAtlasRotate, name: "backMiddleRightCornerAtlasRotate");
				backBottomLeftCornerAtlasRotate = s.Serialize<int>(backBottomLeftCornerAtlasRotate, name: "backBottomLeftCornerAtlasRotate");
				backBottomMiddleCornerAtlasRotate = s.Serialize<int>(backBottomMiddleCornerAtlasRotate, name: "backBottomMiddleCornerAtlasRotate");
				backBottomRightCornerAtlasRotate = s.Serialize<int>(backBottomRightCornerAtlasRotate, name: "backBottomRightCornerAtlasRotate");
				backTopMiddleCornerAtlasTile = s.Serialize<bool>(backTopMiddleCornerAtlasTile, name: "backTopMiddleCornerAtlasTile");
				backMiddleLeftCornerAtlasTile = s.Serialize<bool>(backMiddleLeftCornerAtlasTile, name: "backMiddleLeftCornerAtlasTile");
				backMiddleRightCornerAtlasTile = s.Serialize<bool>(backMiddleRightCornerAtlasTile, name: "backMiddleRightCornerAtlasTile");
				backBottomMiddleCornerAtlasTile = s.Serialize<bool>(backBottomMiddleCornerAtlasTile, name: "backBottomMiddleCornerAtlasTile");
				xUVToDistance = s.Serialize<float>(xUVToDistance, name: "xUVToDistance");
				yUVToDistance = s.Serialize<float>(yUVToDistance, name: "yUVToDistance");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				dynamicAMVMinimunBorderSize = s.Serialize<float>(dynamicAMVMinimunBorderSize, name: "dynamicAMVMinimunBorderSize");
				shadowOffset = s.SerializeObject<Vec3d>(shadowOffset, name: "shadowOffset");
				shadowAlpha = s.Serialize<float>(shadowAlpha, name: "shadowAlpha");
				shadowUseFrontTexture = s.Serialize<bool>(shadowUseFrontTexture, name: "shadowUseFrontTexture");
				posShadowRelative = s.Serialize<bool>(posShadowRelative, name: "posShadowRelative");
				highlightOffset = s.SerializeObject<Vec3d>(highlightOffset, name: "highlightOffset");
				highlightAlpha = s.Serialize<float>(highlightAlpha, name: "highlightAlpha");
				highlightScale = s.SerializeObject<Vec2d>(highlightScale, name: "highlightScale");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					highlightTexture = s.SerializeObject<Path>(highlightTexture, name: "highlightTexture");
				}
				highlightMaterial = s.SerializeObject<GFXMaterialSerializable>(highlightMaterial, name: "highlightMaterial");
			} else if (Settings.s.game == Settings.Game.COL) {
				is2D = s.Serialize<bool>(is2D, name: "is2D");
				addBorders = s.Serialize<bool>(addBorders, name: "addBorders");
				useAnimMeshVertex = s.Serialize<bool>(useAnimMeshVertex, name: "useAnimMeshVertex");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					frontTexture = s.SerializeObject<Path>(frontTexture, name: "frontTexture");
				}
				frontMaterial = s.SerializeObject<GFXMaterialSerializable>(frontMaterial, name: "frontMaterial");
				leftWidth = s.Serialize<float>(leftWidth, name: "leftWidth");
				rightWidth = s.Serialize<float>(rightWidth, name: "rightWidth");
				topHeight = s.Serialize<float>(topHeight, name: "topHeight");
				bottomHeight = s.Serialize<float>(bottomHeight, name: "bottomHeight");
				backTopLeftCornerAtlasIndex = s.Serialize<uint>(backTopLeftCornerAtlasIndex, name: "backTopLeftCornerAtlasIndex");
				backTopMiddleCornerAtlasIndex = s.Serialize<uint>(backTopMiddleCornerAtlasIndex, name: "backTopMiddleCornerAtlasIndex");
				backTopRightCornerAtlasIndex = s.Serialize<uint>(backTopRightCornerAtlasIndex, name: "backTopRightCornerAtlasIndex");
				backMiddleLeftCornerAtlasIndex = s.Serialize<uint>(backMiddleLeftCornerAtlasIndex, name: "backMiddleLeftCornerAtlasIndex");
				backMiddleMiddleCornerAtlasIndex = s.Serialize<uint>(backMiddleMiddleCornerAtlasIndex, name: "backMiddleMiddleCornerAtlasIndex");
				backMiddleRightCornerAtlasIndex = s.Serialize<uint>(backMiddleRightCornerAtlasIndex, name: "backMiddleRightCornerAtlasIndex");
				backBottomLeftCornerAtlasIndex = s.Serialize<uint>(backBottomLeftCornerAtlasIndex, name: "backBottomLeftCornerAtlasIndex");
				backBottomMiddleCornerAtlasIndex = s.Serialize<uint>(backBottomMiddleCornerAtlasIndex, name: "backBottomMiddleCornerAtlasIndex");
				backBottomRightCornerAtlasIndex = s.Serialize<uint>(backBottomRightCornerAtlasIndex, name: "backBottomRightCornerAtlasIndex");
				backTopLeftCornerAtlasRotate = s.Serialize<int>(backTopLeftCornerAtlasRotate, name: "backTopLeftCornerAtlasRotate");
				backTopMiddleCornerAtlasRotate = s.Serialize<int>(backTopMiddleCornerAtlasRotate, name: "backTopMiddleCornerAtlasRotate");
				backTopRightCornerAtlasRotate = s.Serialize<int>(backTopRightCornerAtlasRotate, name: "backTopRightCornerAtlasRotate");
				backMiddleLeftCornerAtlasRotate = s.Serialize<int>(backMiddleLeftCornerAtlasRotate, name: "backMiddleLeftCornerAtlasRotate");
				backMiddleMiddleCornerAtlasRotate = s.Serialize<int>(backMiddleMiddleCornerAtlasRotate, name: "backMiddleMiddleCornerAtlasRotate");
				backMiddleRightCornerAtlasRotate = s.Serialize<int>(backMiddleRightCornerAtlasRotate, name: "backMiddleRightCornerAtlasRotate");
				backBottomLeftCornerAtlasRotate = s.Serialize<int>(backBottomLeftCornerAtlasRotate, name: "backBottomLeftCornerAtlasRotate");
				backBottomMiddleCornerAtlasRotate = s.Serialize<int>(backBottomMiddleCornerAtlasRotate, name: "backBottomMiddleCornerAtlasRotate");
				backBottomRightCornerAtlasRotate = s.Serialize<int>(backBottomRightCornerAtlasRotate, name: "backBottomRightCornerAtlasRotate");
				backTopMiddleCornerAtlasTile = s.Serialize<bool>(backTopMiddleCornerAtlasTile, name: "backTopMiddleCornerAtlasTile");
				backMiddleLeftCornerAtlasTile = s.Serialize<bool>(backMiddleLeftCornerAtlasTile, name: "backMiddleLeftCornerAtlasTile");
				backMiddleRightCornerAtlasTile = s.Serialize<bool>(backMiddleRightCornerAtlasTile, name: "backMiddleRightCornerAtlasTile");
				backBottomMiddleCornerAtlasTile = s.Serialize<bool>(backBottomMiddleCornerAtlasTile, name: "backBottomMiddleCornerAtlasTile");
				xUVToDistance = s.Serialize<float>(xUVToDistance, name: "xUVToDistance");
				yUVToDistance = s.Serialize<float>(yUVToDistance, name: "yUVToDistance");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				dynamicAMVMinimunBorderSize = s.Serialize<float>(dynamicAMVMinimunBorderSize, name: "dynamicAMVMinimunBorderSize");
				shadowOffset = s.SerializeObject<Vec3d>(shadowOffset, name: "shadowOffset");
				shadowAlpha = s.Serialize<float>(shadowAlpha, name: "shadowAlpha");
				shadowUseFrontTexture = s.Serialize<bool>(shadowUseFrontTexture, name: "shadowUseFrontTexture");
				posShadowRelative = s.Serialize<bool>(posShadowRelative, name: "posShadowRelative");
				highlightOffset = s.SerializeObject<Vec3d>(highlightOffset, name: "highlightOffset");
				highlightAlpha = s.Serialize<float>(highlightAlpha, name: "highlightAlpha");
				highlightScale = s.SerializeObject<Vec2d>(highlightScale, name: "highlightScale");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					highlightTexture = s.SerializeObject<Path>(highlightTexture, name: "highlightTexture");
				}
				highlightMaterial = s.SerializeObject<GFXMaterialSerializable>(highlightMaterial, name: "highlightMaterial");
			} else {
				is2D = s.Serialize<bool>(is2D, name: "is2D");
				addBorders = s.Serialize<bool>(addBorders, name: "addBorders");
				useAnimMeshVertex = s.Serialize<bool>(useAnimMeshVertex, name: "useAnimMeshVertex");
				anims = s.SerializeObject<CList<RenderSingleAnimData>>(anims, name: "anims");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				AdditionalMaterials = s.SerializeObject<CList<GFXMaterialSerializable>>(AdditionalMaterials, name: "AdditionalMaterials");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					frontTexture = s.SerializeObject<Path>(frontTexture, name: "frontTexture");
				}
				frontMaterial = s.SerializeObject<GFXMaterialSerializable>(frontMaterial, name: "frontMaterial");
				leftWidth = s.Serialize<float>(leftWidth, name: "leftWidth");
				rightWidth = s.Serialize<float>(rightWidth, name: "rightWidth");
				topHeight = s.Serialize<float>(topHeight, name: "topHeight");
				bottomHeight = s.Serialize<float>(bottomHeight, name: "bottomHeight");
				backTopLeftCornerAtlasIndex = s.Serialize<uint>(backTopLeftCornerAtlasIndex, name: "backTopLeftCornerAtlasIndex");
				backTopMiddleCornerAtlasIndex = s.Serialize<uint>(backTopMiddleCornerAtlasIndex, name: "backTopMiddleCornerAtlasIndex");
				backTopRightCornerAtlasIndex = s.Serialize<uint>(backTopRightCornerAtlasIndex, name: "backTopRightCornerAtlasIndex");
				backMiddleLeftCornerAtlasIndex = s.Serialize<uint>(backMiddleLeftCornerAtlasIndex, name: "backMiddleLeftCornerAtlasIndex");
				backMiddleMiddleCornerAtlasIndex = s.Serialize<uint>(backMiddleMiddleCornerAtlasIndex, name: "backMiddleMiddleCornerAtlasIndex");
				backMiddleRightCornerAtlasIndex = s.Serialize<uint>(backMiddleRightCornerAtlasIndex, name: "backMiddleRightCornerAtlasIndex");
				backBottomLeftCornerAtlasIndex = s.Serialize<uint>(backBottomLeftCornerAtlasIndex, name: "backBottomLeftCornerAtlasIndex");
				backBottomMiddleCornerAtlasIndex = s.Serialize<uint>(backBottomMiddleCornerAtlasIndex, name: "backBottomMiddleCornerAtlasIndex");
				backBottomRightCornerAtlasIndex = s.Serialize<uint>(backBottomRightCornerAtlasIndex, name: "backBottomRightCornerAtlasIndex");
				backTopLeftCornerAtlasRotate = s.Serialize<int>(backTopLeftCornerAtlasRotate, name: "backTopLeftCornerAtlasRotate");
				backTopMiddleCornerAtlasRotate = s.Serialize<int>(backTopMiddleCornerAtlasRotate, name: "backTopMiddleCornerAtlasRotate");
				backTopRightCornerAtlasRotate = s.Serialize<int>(backTopRightCornerAtlasRotate, name: "backTopRightCornerAtlasRotate");
				backMiddleLeftCornerAtlasRotate = s.Serialize<int>(backMiddleLeftCornerAtlasRotate, name: "backMiddleLeftCornerAtlasRotate");
				backMiddleMiddleCornerAtlasRotate = s.Serialize<int>(backMiddleMiddleCornerAtlasRotate, name: "backMiddleMiddleCornerAtlasRotate");
				backMiddleRightCornerAtlasRotate = s.Serialize<int>(backMiddleRightCornerAtlasRotate, name: "backMiddleRightCornerAtlasRotate");
				backBottomLeftCornerAtlasRotate = s.Serialize<int>(backBottomLeftCornerAtlasRotate, name: "backBottomLeftCornerAtlasRotate");
				backBottomMiddleCornerAtlasRotate = s.Serialize<int>(backBottomMiddleCornerAtlasRotate, name: "backBottomMiddleCornerAtlasRotate");
				backBottomRightCornerAtlasRotate = s.Serialize<int>(backBottomRightCornerAtlasRotate, name: "backBottomRightCornerAtlasRotate");
				backTopMiddleCornerAtlasTile = s.Serialize<bool>(backTopMiddleCornerAtlasTile, name: "backTopMiddleCornerAtlasTile");
				backMiddleLeftCornerAtlasTile = s.Serialize<bool>(backMiddleLeftCornerAtlasTile, name: "backMiddleLeftCornerAtlasTile");
				backMiddleRightCornerAtlasTile = s.Serialize<bool>(backMiddleRightCornerAtlasTile, name: "backMiddleRightCornerAtlasTile");
				backBottomMiddleCornerAtlasTile = s.Serialize<bool>(backBottomMiddleCornerAtlasTile, name: "backBottomMiddleCornerAtlasTile");
				xUVToDistance = s.Serialize<float>(xUVToDistance, name: "xUVToDistance");
				yUVToDistance = s.Serialize<float>(yUVToDistance, name: "yUVToDistance");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				dynamicAMVMinimunBorderSize = s.Serialize<float>(dynamicAMVMinimunBorderSize, name: "dynamicAMVMinimunBorderSize");
				shadowOffset = s.SerializeObject<Vec3d>(shadowOffset, name: "shadowOffset");
				shadowAlpha = s.Serialize<float>(shadowAlpha, name: "shadowAlpha");
				shadowUseFrontTexture = s.Serialize<bool>(shadowUseFrontTexture, name: "shadowUseFrontTexture");
				posShadowRelative = s.Serialize<bool>(posShadowRelative, name: "posShadowRelative");
				highlightOffset = s.SerializeObject<Vec3d>(highlightOffset, name: "highlightOffset");
				highlightAlpha = s.Serialize<float>(highlightAlpha, name: "highlightAlpha");
				highlightScale = s.SerializeObject<Vec2d>(highlightScale, name: "highlightScale");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					highlightTexture = s.SerializeObject<Path>(highlightTexture, name: "highlightTexture");
				}
				highlightMaterial = s.SerializeObject<GFXMaterialSerializable>(highlightMaterial, name: "highlightMaterial");
			}
		}
		public override uint? ClassCRC => 0x5619D5B6;
	}
}

