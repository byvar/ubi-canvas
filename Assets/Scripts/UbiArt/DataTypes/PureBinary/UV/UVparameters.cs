namespace UbiArt.UV {
	public class UVparameters : CSerializable {
		public float unkFloat;
		public string unkString;
		public CArrayO<Parameters> parameters;
		public CArrayO<Triangle> triangles;

		protected override void SerializeImpl(CSerializerObject s) {
			unkFloat = s.Serialize<float>(unkFloat, name: "unkFloat");
			unkString = s.Serialize<string>(unkString, name: "unkString");
			parameters = s.SerializeObject<CArrayO<Parameters>>(parameters, name: "parameters");
			triangles = s.SerializeObject<CArrayO<Triangle>>(triangles, name: "triangles");
		}
		public class Triangle : CSerializable {
			public int vertex1;
			public int vertex2;
			public int vertex3;
			protected override void SerializeImpl(CSerializerObject s) {
				vertex1 = s.Serialize<int>(vertex1, name: "vertex1");
				vertex2 = s.Serialize<int>(vertex2, name: "vertex2");
				vertex3 = s.Serialize<int>(vertex3, name: "vertex3");
			}
		}
		public class Parameters : CSerializable {
			public float x;
			public float y;
			protected override void SerializeImpl(CSerializerObject s) {
				x = s.Serialize<float>(x, name: "x");
				y = s.Serialize<float>(y, name: "y");
			}
		}
	}
}
