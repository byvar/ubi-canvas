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
		public uint version;
		public CListP<int> textureConfigIndexBySlope;
		public CListP<int> textureConfigIndexByZone;
		public CListO<FriseTextureConfig> textureConfigs;
		public int unk0;
		public Path gameMaterial;
		public Path gameMaterialExtremityStart;
		public Path gameMaterialExtremityStop;
		public StringID regionId;
		public bool useFriezeFlipToFlipUV;
		public float cornerFactor;
		public uint unkUint;
		public StringID sid0;
		public string configName;
		public StringID configId;
		public int int1;
		public float flt1;
		public int int2;
		public float flt2;
		public float flt3;
		public int int3;
		public float flt4;
		public float flt5;
		public float flt6;
		public float flt7;
		public float flt8;


		public uint methode;
		public float snapCoeff;
		public float snapCoeffUv;
		public float flexibility;
		public Angle wallAngle;
		public bool isUvFlipX;
		public bool isUvFlipY;
		public bool isRatioFixed;
		public float smoothFactorVisual;
		public float scale;
		public float density;
		public uint uint0;
		public CollisionFrieze collision;

		public float flt9;
		public float flt10;
		public Vec2d vec0;

		public ITF.VertexAnim VertexAnim;

		public ColorInteger col;
		public float flt11;
		public float flt12;
		public float flt13;
		public float flt14;
		public float flt15;
		public float flt16;
		public float flt17;
		public float flt18;
		public float flt19;
		public float flt20;
		public float flt21;
		public float flt22;
		public uint uint1;
		public float flt23;
		public float flt24;
		public float flt25;
		public uint uint2;
		public uint uint3;
		public float flt26;
		public float flt27;
		public float flt28;
		public Vec2d vec1;
		public uint uint4;
		public float flt29;
		public float flt30;
		public float flt31;
		public float flt32;
		public uint uint5;
		public float flt33;
		public float flt34;
		public float flt35;
		public float flt36;
		public float flt37;
		public float flt38;
		public float flt39;
		public uint uint6;
		public CListO<FluidFriseLayer> Layers;
		public uint uint7;
		public int int4;
		public float flt40;
		public float flt41;
		public int int5;
		public int int6;
		public int int7;
		public int int8;
		public StringID sid1;
		public CMap<StringID, float> map;
		public int int9;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			textureConfigIndexBySlope = s.SerializeObject<CListP<int>>(textureConfigIndexBySlope, name: "textureConfigIndexBySlope");
			textureConfigIndexByZone = s.SerializeObject<CListP<int>>(textureConfigIndexByZone, name: "textureConfigIndexByZone");
			textureConfigs = s.SerializeObject<CListO<FriseTextureConfig>>(textureConfigs, name: "textureConfigs");
			unk0 = s.Serialize<int>(unk0, name: "unk0");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			gameMaterialExtremityStart = s.SerializeObject<Path>(gameMaterialExtremityStart, name: "gameMaterialExtremityStart");
			gameMaterialExtremityStop = s.SerializeObject<Path>(gameMaterialExtremityStop, name: "gameMaterialExtremityStop");
			regionId = s.SerializeObject<StringID>(regionId, name: "regionId");
			useFriezeFlipToFlipUV = s.Serialize<bool>(useFriezeFlipToFlipUV, name: "useFriezeFlipToFlipUV");
			cornerFactor = s.Serialize<float>(cornerFactor, name: "cornerFactor");
			unkUint = s.Serialize<uint>(unkUint, name: "unkUint");
			sid0 = s.SerializeObject<StringID>(sid0, name: "sid0");
			configName = s.Serialize<string>(configName, name: "configName");
			configId = s.SerializeObject<StringID>(configId, name: "configId");

			int1 = s.Serialize<int>(int1, name: "int1");
			flt1 = s.Serialize<float>(flt1, name: "flt1");
			int2 = s.Serialize<int>(int2, name: "int2");
			flt2 = s.Serialize<float>(flt2, name: "flt2");
			flt3 = s.Serialize<float>(flt3, name: "flt3");
			int3 = s.Serialize<int>(int3, name: "int3");
			flt4 = s.Serialize<float>(flt4, name: "flt4");
			flt5 = s.Serialize<float>(flt5, name: "flt5");
			flt6 = s.Serialize<float>(flt6, name: "flt6");
			flt7 = s.Serialize<float>(flt7, name: "flt7");
			flt8 = s.Serialize<float>(flt8, name: "flt8");

			methode = s.Serialize<uint>(methode, name: "methode");
			snapCoeff = s.Serialize<float>(snapCoeff, name: "snapCoeff");
			snapCoeffUv = s.Serialize<float>(snapCoeffUv, name: "snapCoeffUv");
			flexibility = s.Serialize<float>(flexibility, name: "flexibility");
			wallAngle = s.SerializeObject<Angle>(wallAngle, name: "wallAngle");
			isUvFlipX = s.Serialize<bool>(isUvFlipX, name: "isUvFlipX");
			isUvFlipY = s.Serialize<bool>(isUvFlipY, name: "isUvFlipY");
			isRatioFixed = s.Serialize<bool>(isRatioFixed, name: "isRatioFixed");
			smoothFactorVisual = s.Serialize<float>(smoothFactorVisual, name: "smoothFactorVisual");
			scale = s.Serialize<float>(scale, name: "scale");
			density = s.Serialize<float>(density, name: "density");
			uint0 = s.Serialize<uint>(uint0, name: "uint0");
			collision = s.SerializeObject<CollisionFrieze>(collision, name: "collision");

			flt9 = s.Serialize<float>(flt9, name: "flt9");
			flt10 = s.Serialize<float>(flt10, name: "flt10");
			vec0 = s.SerializeObject<Vec2d>(vec0, name: "vec0");
			VertexAnim = s.SerializeObject<ITF.VertexAnim>(VertexAnim, name: "VertexAnim");

			col = s.SerializeObject<ColorInteger>(col, name: "col");
			flt11 = s.Serialize<float>(flt11, name: "flt11");
			flt12 = s.Serialize<float>(flt12, name: "flt12");
			flt13 = s.Serialize<float>(flt13, name: "flt13");
			flt14 = s.Serialize<float>(flt14, name: "flt14");
			flt15 = s.Serialize<float>(flt15, name: "flt15");
			flt16 = s.Serialize<float>(flt16, name: "flt16");
			flt17 = s.Serialize<float>(flt17, name: "flt17");
			flt18 = s.Serialize<float>(flt18, name: "flt18");
			flt19 = s.Serialize<float>(flt19, name: "flt19");
			flt20 = s.Serialize<float>(flt20, name: "flt20");
			flt21 = s.Serialize<float>(flt21, name: "flt21");
			flt22 = s.Serialize<float>(flt22, name: "flt22");
			uint1 = s.Serialize<uint>(uint1, name: "uint1");
			flt23 = s.Serialize<float>(flt23, name: "flt23");
			flt24 = s.Serialize<float>(flt24, name: "flt24");
			flt25 = s.Serialize<float>(flt25, name: "flt25");
			uint2 = s.Serialize<uint>(uint2, name: "uint2");
			uint3 = s.Serialize<uint>(uint3, name: "uint3");
			flt26 = s.Serialize<float>(flt26, name: "flt26");
			flt27 = s.Serialize<float>(flt27, name: "flt27");
			flt28 = s.Serialize<float>(flt28, name: "flt28");
			vec1 = s.SerializeObject<Vec2d>(vec1, name: "vec1");
			uint4 = s.Serialize<uint>(uint4, name: "uint4");
			flt29 = s.Serialize<float>(flt29, name: "flt29");
			flt30 = s.Serialize<float>(flt30, name: "flt30");
			flt31 = s.Serialize<float>(flt31, name: "flt31");
			flt32 = s.Serialize<float>(flt32, name: "flt32");
			uint5 = s.Serialize<uint>(uint5, name: "uint5");
			flt33 = s.Serialize<float>(flt33, name: "flt33");
			flt34 = s.Serialize<float>(flt34, name: "flt34");
			flt35 = s.Serialize<float>(flt35, name: "flt35");
			flt36 = s.Serialize<float>(flt36, name: "flt36");
			flt37 = s.Serialize<float>(flt37, name: "flt37");
			flt38 = s.Serialize<float>(flt38, name: "flt38");
			flt39 = s.Serialize<float>(flt39, name: "flt39");
			uint6 = s.Serialize<uint>(uint6, name: "uint6");
			Layers = s.SerializeObject<CListO<FluidFriseLayer>>(Layers, name: "Layers");
			uint7 = s.Serialize<uint>(uint7, name: "uint7");
			int4 = s.Serialize<int>(int4, name: "int4");
			flt40 = s.Serialize<float>(flt40, name: "flt40");
			flt41 = s.Serialize<float>(flt41, name: "flt41");
			int5 = s.Serialize<int>(int5, name: "int5");
			int6 = s.Serialize<int>(int6, name: "int6");
			int7 = s.Serialize<int>(int7, name: "int7");
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				int8 = s.Serialize<int>(int8, name: "int8");
			}
			sid1 = s.SerializeObject<StringID>(sid1, name: "sid1");
			map = s.SerializeObject<CMap<StringID, float>>(map, name: "map");
			int9 = s.Serialize<int>(int9, name: "int9");
		}
	}
}
