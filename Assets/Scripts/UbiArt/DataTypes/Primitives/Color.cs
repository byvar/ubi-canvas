namespace UbiArt {
	public class Color : ICSerializable {
		public float b;
		public float g;
		public float r;
		public float a;

		public Color() {
		}
		public Color(float r, float g, float b, float a) {
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		public void Serialize(CSerializerObject s, string name) {
			b = s.Serialize<float>(b);
			g = s.Serialize<float>(g);
			r = s.Serialize<float>(r);
			a = s.Serialize<float>(a);
		}

		public static Color Black => new Color(0, 0, 0, 1f);
		public static Color White => new Color(1, 1, 1, 1f);

		public override string ToString() {
			return $"Color({r}, {g}, {b}, {a})";
		}
	}
}
