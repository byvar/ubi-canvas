using System;

namespace UbiArt {
	public class Vec2d : ICSerializable {
		public float x;
		public float y;

		public Vec2d() {
		}
		public Vec2d(float x, float y) {
			this.x = x;
			this.y = y;
		}

		public void Serialize(CSerializerObject s, string name) {
			x = s.Serialize<float>(x);
			y = s.Serialize<float>(y);
		}

		public override string ToString() {
			return $"Vec2d({x}, {y})";
		}

		public static Vec2d Zero => new Vec2d();
		public static Vec2d One => new Vec2d(1f, 1f);
		public double Magnitude => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
		public static Vec2d operator +(Vec2d a, Vec2d b) => new Vec2d(a.x + b.x, a.y + b.y);
		public static Vec2d operator -(Vec2d a, Vec2d b) => new Vec2d(a.x - b.x, a.y - b.y);
		public static Vec2d operator *(Vec2d a, float b) => new Vec2d(a.x * b, a.y * b);
		public static Vec2d operator /(Vec2d a, float b) => a * 1/b;
		public Vec2d Normalize() => (x != 0 || y != 0) ? this / (float)Magnitude : this;

		// In radians
		public Vec2d Rotate(float angle) {
			var cos = MathF.Cos(angle);
			var sin = MathF.Sin(angle);
			return new Vec2d(
				x * cos - y * sin,
				x * sin + y * cos);
		}

		public static Vec2d Left => new Vec2d(-1,0);
		public static Vec2d Right => new Vec2d(1, 0);
		public static Vec2d Up => new Vec2d(0, 1);
		public static Vec2d Down => new Vec2d(0, -1);
	}
}
