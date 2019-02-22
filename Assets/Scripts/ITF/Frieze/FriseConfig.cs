using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	// In Adventures, FriseConfig is a subclass of Actor_Template
	public class FriseConfig : TemplatePickable {
		[Serialize(0, "gameMaterial")] public Path gameMaterial;
		[Serialize(1, "gameMaterialExtremityStart")] public Path gameMaterialExtremityStart;
		[Serialize(2, "gameMaterialExtremityStop")] public Path gameMaterialExtremityStop;
		[Serialize(3, "visualOffset")] public float visualOffset;
		[Serialize(4, "regionId")] public StringID regionId;
		[Serialize(5, "useFriezeFlipToFlipUV")] public bool useFriezeFlipToFlipUV;
		[Serialize(6, "cornerFactor")] public float cornerFactor;
		[Serialize(7, "height")] public float height;
		[Serialize(8, "width")] public float width;
		[Serialize(9, "methode")] public uint methode;
		[Serialize(10, "snapCoeff")] public float snapCoeff;
		[Serialize(11, "snapCoeffUv")] public float snapCoeffUv;
		[Serialize(12, "flexibilty")] public float flexibilty;
		[Serialize(13, "wallAngle")] public Angle wallAngle;
		[Serialize(14, "isUvFlipX")] public bool isUvFlipX;
		[Serialize(15, "isUvFlipY")] public bool isUvFlipY;
		[Serialize(16, "isRatioFixed")] public bool isRatioFixed;
		[Serialize(17, "smoothFactorVisual")] public float smoothFactorVisual;
		[Serialize(18, "scale")] public float scale;
		[Serialize(19, "density")] public float density;
		[Serialize(20, "collision")] public CollisionFrieze collision;
		[Serialize(21, "fill")] public FillConfig fill;
		[Serialize(22, "zExtrudeUp")] public float zExtrudeUp;
		[Serialize(23, "zExtrudeDown")] public float zExtrudeDown;
		[Serialize(24, "zExtrudeStop")] public float zExtrudeStop;
		[Serialize(25, "zExtrudeStart")] public float zExtrudeStart;
		[Serialize(26, "zExtrudeExtremityStart")] public float zExtrudeExtremityStart;
		[Serialize(27, "zExtrudeExtremityStop")] public float zExtrudeExtremityStop;
		[Serialize(28, "patchCoeffOffset")] public float patchCoeffOffset;
		[Serialize(29, "patchScale")] public float patchScale;
		[Serialize(30, "patchOriented")] public bool patchOriented;
		[Serialize(31, "patchCornerFactorCollision")] public float patchCornerFactorCollision;
		[Serialize(32, "patchAngleMin")] public Angle patchAngleMin;
		[Serialize(33, "ExtremityScale")] public Vector2 extremityScale;
		[Serialize(34, "selfIllumColor")] public ColorInteger selfIllumColor;
		[Serialize(35, "textureConfigs")] public Container<FriseTextureConfig> textureConfigs;
		[Serialize(36, "VertexAnim")] public VertexAnim vertexAnim;
		[Serialize(37, "Fluid")] public FluidConfig fluid;
		[Serialize(38, "skewAngle")] public float skewAngle;
		[Serialize(39, "isDigShape")] public bool isDigShape;
		[Serialize(40, "isLockedDigShape")] public bool isLockedDigShape;
		[Serialize(41, "switchExtremityAuto")] public bool switchExtremityAuto;
		[Serialize(42, "offsetExtremity")] public float offsetExtremity;
		[Serialize(43, "idTexSwitch")] public int idTexSwitch;
		[Serialize(44, "cooked")] public bool cooked;
		[Serialize(45, "textureConfigIndexBySlope")] public Container<int> textureConfigIndexBySlope;
		[Serialize(46, "textureConfigIndexByZone")] public Container<int> textureConfigIndexByZone;
		[Serialize(47, "smoothVisual")] public bool smoothVisual;
		[Serialize(48, "PrimitiveParameters")] public GFXPrimitiveParam primitiveParameters;

		public FriseConfig(Reader reader) : base(reader) {
		}
	}
}
