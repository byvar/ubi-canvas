namespace UbiArt {
	public class Vec3d : ICSerializable {
		public float x;
		public float y;
		public float z;

		public Vec3d() {}
		public Vec3d(float x, float y, float z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Serialize(CSerializerObject s, string name) {
			x = s.Serialize<float>(x);
			y = s.Serialize<float>(y);
			z = s.Serialize<float>(z);
		}
		public static Vec3d Zero => new Vec3d();
		public static Vec3d One => new Vec3d() { x = 1f, y = 1f, z = 1f };

		public override string ToString() => $"Vec3d({x}, {y}, {z})";
	}
}
