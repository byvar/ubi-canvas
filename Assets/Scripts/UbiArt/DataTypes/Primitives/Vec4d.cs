namespace UbiArt {
	public class Vec4d : ICSerializable {
		public float x;
		public float y;
		public float z;
		public float w;

		public Vec4d() {}
		public Vec4d(float x, float y, float z, float w) {
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public void Serialize(CSerializerObject s, string name) {
			x = s.Serialize<float>(x);
			y = s.Serialize<float>(y);
			z = s.Serialize<float>(z);
			w = s.Serialize<float>(w);
		}
		public static Vec4d Zero => new Vec4d();
		public static Vec4d One => new Vec4d(1,1,1,1);

		public override string ToString() => $"Vec4d({x}, {y}, {z}, {w})";
	}
}
