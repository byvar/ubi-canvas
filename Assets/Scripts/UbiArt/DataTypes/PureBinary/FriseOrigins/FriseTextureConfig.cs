namespace UbiArt.FriseOrigins {
	// See: ITF::FriseTextureConfig::serialize
	public class FriseTextureConfig : CSerializable {
		public CString diffuse;
		public CString texture2;
		public CString texture3;
		public float flt3;
		public float flt4;
		public float flt5;
		public float flt6;
		public float flt7;
		public int int8;
		public int int9;
		public int int10;
		public ColorInteger color;
		public Vec2d vecA;
		public Vec2d vecB;
		public float flt8;
		public Path gameMaterial;
		public CString friendly;
		public ColorInteger color2;
		public CollisionFrieze collision1;
		public CollisionFrieze collision2;
		public Vec2d scrollUV;
		public float scrollAngle;
		public byte alphaBorder;
		public byte alphaUp;
		public uint uint1;
		public uint uint2;
		public float flt10;
		public float flt11;
		public float flt12;
		public float flt13;
		public int int0;
		public int int1;
		public int int2;
		public uint uint3;
		public float flt14;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			diffuse = s.Serialize<CString>(diffuse, name: "diffuse");
			texture2 = s.Serialize<CString>(texture2, name: "texture2");
			texture3 = s.Serialize<CString>(texture3, name: "texture3");
			flt3 = s.Serialize<float>(flt3, name: "flt3");
			flt4 = s.Serialize<float>(flt4, name: "flt4");
			flt5 = s.Serialize<float>(flt5, name: "flt5");
			flt6 = s.Serialize<float>(flt6, name: "flt6");
			flt7 = s.Serialize<float>(flt7, name: "flt7");
			int8 = s.Serialize<int>(int8, name: "int8");
			int9 = s.Serialize<int>(int9, name: "int9");
			int10 = s.Serialize<int>(int10, name: "int10");
			color = s.SerializeObject<ColorInteger>(color, name: "color");
			vecA = s.SerializeObject<Vec2d>(vecA, name: "vecA");
			vecB = s.SerializeObject<Vec2d>(vecB, name: "vecB");
			flt8 = s.Serialize<float>(flt8, name: "flt8");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			friendly = s.Serialize<CString>(friendly, name: "friendly");
			color2 = s.SerializeObject<ColorInteger>(color2, name: "color2");
			collision1 = s.SerializeObject<CollisionFrieze>(collision1, name: "collision1");
			collision2 = s.SerializeObject<CollisionFrieze>(collision2, name: "collision2");
			scrollUV = s.SerializeObject<Vec2d>(scrollUV, name: "scrollUV");
			scrollAngle = s.Serialize<float>(scrollAngle, name: "scrollAngle");
			alphaBorder = s.Serialize<byte>(alphaBorder, name: "alphaBorder");
			alphaUp = s.Serialize<byte>(alphaUp, name: "alphaUp");
			uint1 = s.Serialize<uint>(uint1, name: "uint1");
			uint2 = s.Serialize<uint>(uint2, name: "uint2");
			flt10 = s.Serialize<float>(flt10, name: "flt10");
			flt11 = s.Serialize<float>(flt11, name: "flt11");
			flt12 = s.Serialize<float>(flt12, name: "flt12");
			flt13 = s.Serialize<float>(flt13, name: "flt13");
			int0 = s.Serialize<int>(int0, name: "int0");
			int1 = s.Serialize<int>(int1, name: "int1");
			int2 = s.Serialize<int>(int2, name: "int2");
			uint3 = s.Serialize<uint>(uint3, name: "uint3");
			flt14 = s.Serialize<float>(flt14, name: "flt14");
		}
	}
}
