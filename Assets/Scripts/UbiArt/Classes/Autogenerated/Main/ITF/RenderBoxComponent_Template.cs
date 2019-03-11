using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderBoxComponent_Template : GraphicComponent_Template {
		[Serialize("is2D"                             )] public bool is2D;
		[Serialize("addBorders"                       )] public bool addBorders;
		[Serialize("useAnimMeshVertex"                )] public bool useAnimMeshVertex;
		[Serialize("anims"                            )] public CList<RenderSingleAnimData> anims;
		[Serialize("texture"                          )] public Path texture;
		[Serialize("material"                         )] public GFXMaterialSerializable material;
		[Serialize("AdditionalMaterials"              )] public CList<GFXMaterialSerializable> AdditionalMaterials;
		[Serialize("frontTexture"                     )] public Path frontTexture;
		[Serialize("frontMaterial"                    )] public GFXMaterialSerializable frontMaterial;
		[Serialize("leftWidth"                        )] public float leftWidth;
		[Serialize("rightWidth"                       )] public float rightWidth;
		[Serialize("topHeight"                        )] public float topHeight;
		[Serialize("bottomHeight"                     )] public float bottomHeight;
		[Serialize("backTopLeftCornerAtlasIndex"      )] public uint backTopLeftCornerAtlasIndex;
		[Serialize("backTopMiddleCornerAtlasIndex"    )] public uint backTopMiddleCornerAtlasIndex;
		[Serialize("backTopRightCornerAtlasIndex"     )] public uint backTopRightCornerAtlasIndex;
		[Serialize("backMiddleLeftCornerAtlasIndex"   )] public uint backMiddleLeftCornerAtlasIndex;
		[Serialize("backMiddleMiddleCornerAtlasIndex" )] public uint backMiddleMiddleCornerAtlasIndex;
		[Serialize("backMiddleRightCornerAtlasIndex"  )] public uint backMiddleRightCornerAtlasIndex;
		[Serialize("backBottomLeftCornerAtlasIndex"   )] public uint backBottomLeftCornerAtlasIndex;
		[Serialize("backBottomMiddleCornerAtlasIndex" )] public uint backBottomMiddleCornerAtlasIndex;
		[Serialize("backBottomRightCornerAtlasIndex"  )] public uint backBottomRightCornerAtlasIndex;
		[Serialize("backTopLeftCornerAtlasRotate"     )] public int backTopLeftCornerAtlasRotate;
		[Serialize("backTopMiddleCornerAtlasRotate"   )] public int backTopMiddleCornerAtlasRotate;
		[Serialize("backTopRightCornerAtlasRotate"    )] public int backTopRightCornerAtlasRotate;
		[Serialize("backMiddleLeftCornerAtlasRotate"  )] public int backMiddleLeftCornerAtlasRotate;
		[Serialize("backMiddleMiddleCornerAtlasRotate")] public int backMiddleMiddleCornerAtlasRotate;
		[Serialize("backMiddleRightCornerAtlasRotate" )] public int backMiddleRightCornerAtlasRotate;
		[Serialize("backBottomLeftCornerAtlasRotate"  )] public int backBottomLeftCornerAtlasRotate;
		[Serialize("backBottomMiddleCornerAtlasRotate")] public int backBottomMiddleCornerAtlasRotate;
		[Serialize("backBottomRightCornerAtlasRotate" )] public int backBottomRightCornerAtlasRotate;
		[Serialize("backTopMiddleCornerAtlasTile"     )] public bool backTopMiddleCornerAtlasTile;
		[Serialize("backMiddleLeftCornerAtlasTile"    )] public bool backMiddleLeftCornerAtlasTile;
		[Serialize("backMiddleRightCornerAtlasTile"   )] public bool backMiddleRightCornerAtlasTile;
		[Serialize("backBottomMiddleCornerAtlasTile"  )] public bool backBottomMiddleCornerAtlasTile;
		[Serialize("xUVToDistance"                    )] public float xUVToDistance;
		[Serialize("yUVToDistance"                    )] public float yUVToDistance;
		[Serialize("zOffset"                          )] public float zOffset;
		[Serialize("dynamicAMVMinimunBorderSize"      )] public float dynamicAMVMinimunBorderSize;
		[Serialize("shadowOffset"                     )] public Vector3 shadowOffset;
		[Serialize("shadowAlpha"                      )] public float shadowAlpha;
		[Serialize("shadowUseFrontTexture"            )] public bool shadowUseFrontTexture;
		[Serialize("posShadowRelative"                )] public bool posShadowRelative;
		[Serialize("highlightOffset"                  )] public Vector3 highlightOffset;
		[Serialize("highlightAlpha"                   )] public float highlightAlpha;
		[Serialize("highlightScale"                   )] public Vector2 highlightScale;
		[Serialize("highlightTexture"                 )] public Path highlightTexture;
		[Serialize("highlightMaterial"                )] public GFXMaterialSerializable highlightMaterial;
		[Serialize("backTopLeftCornerAtlasRotate"     )] public bool backTopLeftCornerAtlasRotate;
		[Serialize("backTopMiddleCornerAtlasRotate"   )] public bool backTopMiddleCornerAtlasRotate;
		[Serialize("backTopRightCornerAtlasRotate"    )] public bool backTopRightCornerAtlasRotate;
		[Serialize("backMiddleLeftCornerAtlasRotate"  )] public bool backMiddleLeftCornerAtlasRotate;
		[Serialize("backMiddleMiddleCornerAtlasRotate")] public bool backMiddleMiddleCornerAtlasRotate;
		[Serialize("backMiddleRightCornerAtlasRotate" )] public bool backMiddleRightCornerAtlasRotate;
		[Serialize("backBottomLeftCornerAtlasRotate"  )] public bool backBottomLeftCornerAtlasRotate;
		[Serialize("backBottomMiddleCornerAtlasRotate")] public bool backBottomMiddleCornerAtlasRotate;
		[Serialize("backBottomRightCornerAtlasRotate" )] public bool backBottomRightCornerAtlasRotate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(is2D));
				SerializeField(s, nameof(addBorders));
				SerializeField(s, nameof(useAnimMeshVertex));
				SerializeField(s, nameof(anims));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(frontTexture));
				}
				SerializeField(s, nameof(frontMaterial));
				SerializeField(s, nameof(leftWidth));
				SerializeField(s, nameof(rightWidth));
				SerializeField(s, nameof(topHeight));
				SerializeField(s, nameof(bottomHeight));
				SerializeField(s, nameof(backTopLeftCornerAtlasIndex));
				SerializeField(s, nameof(backTopMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backTopRightCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleRightCornerAtlasIndex));
				SerializeField(s, nameof(backBottomLeftCornerAtlasIndex));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backBottomRightCornerAtlasIndex));
				SerializeField(s, nameof(backTopLeftCornerAtlasRotate));
				SerializeField(s, nameof(backTopMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backTopRightCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleRightCornerAtlasRotate));
				SerializeField(s, nameof(backBottomLeftCornerAtlasRotate));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backBottomRightCornerAtlasRotate));
				SerializeField(s, nameof(backTopMiddleCornerAtlasTile));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasTile));
				SerializeField(s, nameof(backMiddleRightCornerAtlasTile));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasTile));
				SerializeField(s, nameof(xUVToDistance));
				SerializeField(s, nameof(yUVToDistance));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(dynamicAMVMinimunBorderSize));
				SerializeField(s, nameof(shadowOffset));
				SerializeField(s, nameof(shadowAlpha));
				SerializeField(s, nameof(shadowUseFrontTexture));
				SerializeField(s, nameof(posShadowRelative));
				SerializeField(s, nameof(highlightOffset));
				SerializeField(s, nameof(highlightAlpha));
				SerializeField(s, nameof(highlightScale));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(highlightTexture));
				}
				SerializeField(s, nameof(highlightMaterial));
			} else {
				SerializeField(s, nameof(is2D));
				SerializeField(s, nameof(addBorders));
				SerializeField(s, nameof(useAnimMeshVertex));
				SerializeField(s, nameof(anims));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(AdditionalMaterials));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(frontTexture));
				}
				SerializeField(s, nameof(frontMaterial));
				SerializeField(s, nameof(leftWidth));
				SerializeField(s, nameof(rightWidth));
				SerializeField(s, nameof(topHeight));
				SerializeField(s, nameof(bottomHeight));
				SerializeField(s, nameof(backTopLeftCornerAtlasIndex));
				SerializeField(s, nameof(backTopMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backTopRightCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backMiddleRightCornerAtlasIndex));
				SerializeField(s, nameof(backBottomLeftCornerAtlasIndex));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasIndex));
				SerializeField(s, nameof(backBottomRightCornerAtlasIndex));
				SerializeField(s, nameof(backTopLeftCornerAtlasRotate));
				SerializeField(s, nameof(backTopMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backTopRightCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backMiddleRightCornerAtlasRotate));
				SerializeField(s, nameof(backBottomLeftCornerAtlasRotate));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasRotate));
				SerializeField(s, nameof(backBottomRightCornerAtlasRotate));
				SerializeField(s, nameof(backTopMiddleCornerAtlasTile));
				SerializeField(s, nameof(backMiddleLeftCornerAtlasTile));
				SerializeField(s, nameof(backMiddleRightCornerAtlasTile));
				SerializeField(s, nameof(backBottomMiddleCornerAtlasTile));
				SerializeField(s, nameof(xUVToDistance));
				SerializeField(s, nameof(yUVToDistance));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(dynamicAMVMinimunBorderSize));
				SerializeField(s, nameof(shadowOffset));
				SerializeField(s, nameof(shadowAlpha));
				SerializeField(s, nameof(shadowUseFrontTexture));
				SerializeField(s, nameof(posShadowRelative));
				SerializeField(s, nameof(highlightOffset));
				SerializeField(s, nameof(highlightAlpha));
				SerializeField(s, nameof(highlightScale));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(highlightTexture));
				}
				SerializeField(s, nameof(highlightMaterial));
			}
		}
		public override uint? ClassCRC => 0x5619D5B6;
	}
}

