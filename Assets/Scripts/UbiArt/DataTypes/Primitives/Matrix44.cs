namespace UbiArt {
	public class Matrix44 : ICSerializable {
		// Format: M{Row}{Column}
		public float M00 { get; set; }
		public float M01 { get; set; }
		public float M02 { get; set; }
		public float M03 { get; set; }
		public float M10 { get; set; }
		public float M11 { get; set; }
		public float M12 { get; set; }
		public float M13 { get; set; }
		public float M20 { get; set; }
		public float M21 { get; set; }
		public float M22 { get; set; }
		public float M23 { get; set; }
		public float M30 { get; set; }
		public float M31 { get; set; }
		public float M32 { get; set; }
		public float M33 { get; set; }

		public void Serialize(CSerializerObject s, string name) {
			/*Debug.LogError(s.Position + ": Encountered Matrix44 with name " + name);
			throw new Exception(s.Position + ": Encountered Matrix44 with name " + name);*/
			M00 = s.Serialize<float>(M00);
			M01 = s.Serialize<float>(M01);
			M02 = s.Serialize<float>(M02);
			M03 = s.Serialize<float>(M03);
			M10 = s.Serialize<float>(M10);
			M11 = s.Serialize<float>(M11);
			M12 = s.Serialize<float>(M12);
			M13 = s.Serialize<float>(M13);
			M20 = s.Serialize<float>(M20);
			M21 = s.Serialize<float>(M21);
			M22 = s.Serialize<float>(M22);
			M23 = s.Serialize<float>(M23);
			M30 = s.Serialize<float>(M30);
			M31 = s.Serialize<float>(M31);
			M32 = s.Serialize<float>(M32);
			M33 = s.Serialize<float>(M33);
		}
	}
}
