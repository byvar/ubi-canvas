using System;
using System.Runtime.Serialization;

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

		public override string ToString() => $"Vec3d({x}, {y}, {z})";

		public static Vec3d Zero => new Vec3d();
		public static Vec3d One => new Vec3d() { x = 1f, y = 1f, z = 1f };
		public static Vec3d Invalid => new Vec3d() { x = float.MaxValue, y = float.MaxValue, z = float.MaxValue };

		[IgnoreDataMember]
		public double Magnitude => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

		public static Vec3d operator +(Vec3d a, Vec3d b) => new Vec3d(a.x + b.x, a.y + b.y, a.z + b.z);
		public static Vec3d operator -(Vec3d a, Vec3d b) => new Vec3d(a.x - b.x, a.y - b.y, a.z - b.z);
		public static Vec3d operator *(Vec3d a, Vec3d b) => new Vec3d(a.x * b.x, a.y * b.y, a.z * b.z);
		public static Vec3d operator *(Vec3d a, float b) => new Vec3d(a.x * b, a.y * b, a.z + b);
		public static Vec3d operator /(Vec3d a, float b) => new Vec3d(a.x / b, a.y / b, a.z / b);
		public Vec3d Normalize() => (x != 0 || y != 0 || z != 0) ? this / (float)Magnitude : this;
	}
}
