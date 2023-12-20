using UbiArt.ITF;

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
		public StringID regionId2;
		public string configName;
		public StringID configId;
		public int int1;
		public float flt1;
		public int int2;
		public float visualOffset;
		public float flt3;
		public int int3;
		public float flt4;
		public float flt5;
		public float flt6;
		public float height;
		public float width;


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

		public float fillOffset;
		public Angle fillAngle;
		public Vec2d fillScale;

		public ITF.VertexAnim VertexAnim;

		public ColorInteger col;
		public ITF.FluidConfig Fluid;

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
			regionId2 = s.SerializeObject<StringID>(regionId2, name: "regionId");
			configName = s.Serialize<string>(configName, name: "configName");
			configId = s.SerializeObject<StringID>(configId, name: "configId");

			int1 = s.Serialize<int>(int1, name: "int1");
			flt1 = s.Serialize<float>(flt1, name: "flt1");
			int2 = s.Serialize<int>(int2, name: "int2");
			visualOffset = s.Serialize<float>(visualOffset, name: "visualOffset");
			flt3 = s.Serialize<float>(flt3, name: "flt3");
			int3 = s.Serialize<int>(int3, name: "int3");
			flt4 = s.Serialize<float>(flt4, name: "flt4");
			flt5 = s.Serialize<float>(flt5, name: "flt5");
			flt6 = s.Serialize<float>(flt6, name: "flt6");
			height = s.Serialize<float>(height, name: "height");
			width = s.Serialize<float>(width, name: "witdh");

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

			fillOffset = s.Serialize<float>(fillOffset, name: "fillOffset");
			fillAngle = s.SerializeObject<Angle>(fillAngle, name: "fillAngle");
			fillScale = s.SerializeObject<Vec2d>(fillScale, name: "fillScale");

			VertexAnim = s.SerializeObject<ITF.VertexAnim>(VertexAnim, name: "VertexAnim");

			col = s.SerializeObject<ColorInteger>(col, name: "col");
			Fluid = s.SerializeObject<FluidConfig>(Fluid, name: "Fluid");

			uint7 = s.Serialize<uint>(uint7, name: "uint7");
			int4 = s.Serialize<int>(int4, name: "int4");
			flt40 = s.Serialize<float>(flt40, name: "flt40");
			flt41 = s.Serialize<float>(flt41, name: "flt41");
			int5 = s.Serialize<int>(int5, name: "int5");
			int6 = s.Serialize<int>(int6, name: "int6");
			int7 = s.Serialize<int>(int7, name: "int7");
			if (s.Settings.Game == Game.RFR) {
				int8 = s.Serialize<int>(int8, name: "int8");
			}
			sid1 = s.SerializeObject<StringID>(sid1, name: "sid1");
			map = s.SerializeObject<CMap<StringID, float>>(map, name: "map");
			int9 = s.Serialize<int>(int9, name: "int9");
		}
	}
}
