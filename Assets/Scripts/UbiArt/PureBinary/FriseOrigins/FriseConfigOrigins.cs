using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FriseConfig::serialize
	// fcg.ckd file
	public class FriseConfigOrigins : CSerializable {
		[Serialize("version"    )] public uint version;
		[Serialize("textureConfigIndexBySlope"     )] public CList<int> textureConfigIndexBySlope;
		[Serialize("textureConfigIndexByZone"      )] public CList<int> textureConfigIndexByZone;
		[Serialize("textureConfigs"                )] public CList<FriseTextureConfig> textureConfigs;
		[Serialize("unk0")] public int unk0;
		[Serialize("gameMaterial"                  )] public Path gameMaterial;
		[Serialize("gameMaterialExtremityStart"    )] public Path gameMaterialExtremityStart;
		[Serialize("gameMaterialExtremityStop"     )] public Path gameMaterialExtremityStop;
		[Serialize("regionId"                      )] public StringID regionId;
		[Serialize("useFriezeFlipToFlipUV"         )] public bool useFriezeFlipToFlipUV;
		[Serialize("cornerFactor"                  )] public float cornerFactor;
		[Serialize("unkUint"                       )] public uint unkUint;
		[Serialize("sid0")] public StringID sid0;
		[Serialize("configName"                    )] public string configName;
		[Serialize("configId"                      )] public StringID configId;
		[Serialize("int1")] public int int1;
		[Serialize("flt1")] public float flt1;
		[Serialize("int2")] public int int2;
		[Serialize("flt2")] public float flt2;
		[Serialize("flt3")] public float flt3;
		[Serialize("int3")] public int int3;
		[Serialize("flt4")] public float flt4;
		[Serialize("flt5")] public float flt5;
		[Serialize("flt6")] public float flt6;
		[Serialize("flt7")] public float flt7;
		[Serialize("flt8")] public float flt8;


		[Serialize("methode"                       )] public uint methode;
		[Serialize("snapCoeff"                     )] public float snapCoeff;
		[Serialize("snapCoeffUv"                   )] public float snapCoeffUv;
		[Serialize("flexibility"                   )] public float flexibility;
		[Serialize("wallAngle"                     )] public Angle wallAngle;
		[Serialize("isUvFlipX"                     )] public bool isUvFlipX;
		[Serialize("isUvFlipY"                     )] public bool isUvFlipY;
		[Serialize("isRatioFixed"                  )] public bool isRatioFixed;
		[Serialize("smoothFactorVisual"            )] public float smoothFactorVisual;
		[Serialize("scale"                         )] public float scale;
		[Serialize("density"                       )] public float density;
		[Serialize("uint0")] public uint uint0;
		[Serialize("collision"                     )] public CollisionFrieze collision;

		[Serialize("flt9")] public float flt9;
		[Serialize("flt10")] public float flt10;
		[Serialize("vec0")] public Vector2 vec0;

		[Serialize("VertexAnim"                    )] public ITF.VertexAnim VertexAnim;

		[Serialize("col")] public ColorInteger col;
		[Serialize("flt11")] public float flt11;
		[Serialize("flt12")] public float flt12;
		[Serialize("flt13")] public float flt13;
		[Serialize("flt14")] public float flt14;
		[Serialize("flt15")] public float flt15;
		[Serialize("flt16")] public float flt16;
		[Serialize("flt17")] public float flt17;
		[Serialize("flt18")] public float flt18;
		[Serialize("flt19")] public float flt19;
		[Serialize("flt20")] public float flt20;
		[Serialize("flt21")] public float flt21;
		[Serialize("flt22")] public float flt22;
		[Serialize("uint1")] public uint uint1;
		[Serialize("flt23")] public float flt23;
		[Serialize("flt24")] public float flt24;
		[Serialize("flt25")] public float flt25;
		[Serialize("uint2")] public uint uint2;
		[Serialize("uint3")] public uint uint3;
		[Serialize("flt26")] public float flt26;
		[Serialize("flt27")] public float flt27;
		[Serialize("flt28")] public float flt28;
		[Serialize("vec1")] public Vector2 vec1;
		[Serialize("uint4")] public uint uint4;
		[Serialize("flt29")] public float flt29;
		[Serialize("flt30")] public float flt30;
		[Serialize("flt31")] public float flt31;
		[Serialize("flt32")] public float flt32;
		[Serialize("uint5")] public uint uint5;
		[Serialize("flt33")] public float flt33;
		[Serialize("flt34")] public float flt34;
		[Serialize("flt35")] public float flt35;
		[Serialize("flt36")] public float flt36;
		[Serialize("flt37")] public float flt37;
		[Serialize("flt38")] public float flt38;
		[Serialize("flt39")] public float flt39;
		[Serialize("uint6")] public uint uint6;
		[Serialize("Layers"                 )] public CList<FluidFriseLayer> Layers;
		[Serialize("uint7")] public uint uint7;
		[Serialize("int4")] public int int4;
		[Serialize("flt11")] public float flt40;
		[Serialize("flt12")] public float flt41;
		[Serialize("int5")] public int int5;
		[Serialize("int6")] public int int6;
		[Serialize("int7")] public int int7;
		[Serialize("int8")] public int int8;
		[Serialize("sid1")] public StringID sid1;
		[Serialize("map")] public CMap<StringID, float> map;
		[Serialize("int9")] public int int9;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(textureConfigIndexBySlope));
			SerializeField(s, nameof(textureConfigIndexByZone));
			SerializeField(s, nameof(textureConfigs));
			SerializeField(s, nameof(unk0));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(gameMaterialExtremityStart));
			SerializeField(s, nameof(gameMaterialExtremityStop));
			SerializeField(s, nameof(regionId));
			SerializeField(s, nameof(useFriezeFlipToFlipUV));
			SerializeField(s, nameof(cornerFactor));
			SerializeField(s, nameof(unkUint));
			SerializeField(s, nameof(sid0));
			SerializeField(s, nameof(configName));
			SerializeField(s, nameof(configId));

			SerializeField(s, nameof(int1));
			SerializeField(s, nameof(flt1));
			SerializeField(s, nameof(int2));
			SerializeField(s, nameof(flt2));
			SerializeField(s, nameof(flt3));
			SerializeField(s, nameof(int3));
			SerializeField(s, nameof(flt4));
			SerializeField(s, nameof(flt5));
			SerializeField(s, nameof(flt6));
			SerializeField(s, nameof(flt7));
			SerializeField(s, nameof(flt8));

			SerializeField(s, nameof(methode));
			SerializeField(s, nameof(snapCoeff));
			SerializeField(s, nameof(snapCoeffUv));
			SerializeField(s, nameof(flexibility));
			SerializeField(s, nameof(wallAngle));
			SerializeField(s, nameof(isUvFlipX));
			SerializeField(s, nameof(isUvFlipY));
			SerializeField(s, nameof(isRatioFixed));
			SerializeField(s, nameof(smoothFactorVisual));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(density));
			SerializeField(s, nameof(uint0));
			SerializeField(s, nameof(collision));

			SerializeField(s, nameof(flt9));
			SerializeField(s, nameof(flt10));
			SerializeField(s, nameof(vec0));
			SerializeField(s, nameof(VertexAnim));

			SerializeField(s, nameof(col));
			SerializeField(s, nameof(flt11));
			SerializeField(s, nameof(flt12));
			SerializeField(s, nameof(flt13));
			SerializeField(s, nameof(flt14));
			SerializeField(s, nameof(flt15));
			SerializeField(s, nameof(flt16));
			SerializeField(s, nameof(flt17));
			SerializeField(s, nameof(flt18));
			SerializeField(s, nameof(flt19));
			SerializeField(s, nameof(flt20));
			SerializeField(s, nameof(flt21));
			SerializeField(s, nameof(flt22));
			SerializeField(s, nameof(uint1));
			SerializeField(s, nameof(flt23));
			SerializeField(s, nameof(flt24));
			SerializeField(s, nameof(flt25));
			SerializeField(s, nameof(uint2));
			SerializeField(s, nameof(uint3));
			SerializeField(s, nameof(flt26));
			SerializeField(s, nameof(flt27));
			SerializeField(s, nameof(flt28));
			SerializeField(s, nameof(vec1));
			SerializeField(s, nameof(uint4));
			SerializeField(s, nameof(flt29));
			SerializeField(s, nameof(flt30));
			SerializeField(s, nameof(flt31));
			SerializeField(s, nameof(flt32));
			SerializeField(s, nameof(uint5));
			SerializeField(s, nameof(flt33));
			SerializeField(s, nameof(flt34));
			SerializeField(s, nameof(flt35));
			SerializeField(s, nameof(flt36));
			SerializeField(s, nameof(flt37));
			SerializeField(s, nameof(flt38));
			SerializeField(s, nameof(flt39));
			SerializeField(s, nameof(uint6));
			SerializeField(s, nameof(Layers));
			SerializeField(s, nameof(uint7));
			SerializeField(s, nameof(int4));
			SerializeField(s, nameof(flt40));
			SerializeField(s, nameof(flt41));
			SerializeField(s, nameof(int5));
			SerializeField(s, nameof(int6));
			SerializeField(s, nameof(int7));
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(int8));
			}
			SerializeField(s, nameof(sid1));
			SerializeField(s, nameof(map));
			SerializeField(s, nameof(int9));
		}
	}
}
