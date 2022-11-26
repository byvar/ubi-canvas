using System;

namespace UbiArt {
	public class AngleAmount : ICSerializable {
		public float angle;
		public void Serialize(CSerializerObject s, string name) {
			angle = s.Serialize<float>(angle);
		}

		// Casts
		public static implicit operator float(AngleAmount a) {
			return a.angle;
		}
		public static implicit operator AngleAmount(float a) {
			return new AngleAmount { angle = a };
		}
		public static implicit operator AngleAmount(Angle a) {
			return new AngleAmount { angle = a.angle };
		}

		public float EulerAngle {
			get {
				return angle * Rad2Deg;
			}
			set {
				angle = value * Deg2Rad;
			}
		}
		public override string ToString() => $"Angle({angle}rad|{EulerAngle}°)";

		private readonly float Deg2Rad = (MathF.PI * 2) / 360f;
		private readonly float Rad2Deg = 360f / (MathF.PI * 2);
	}
}
