using System;

namespace UbiArt {
	public class Angle : ICSerializable {
		public float angle;

		public void Serialize(CSerializerObject s, string name) {
			angle = s.Serialize<float>(angle);
		}

		// Constructors
		public Angle() { }
		public Angle(float angle, bool degrees = false) {
			if (degrees) {
				EulerAngle = angle;
			} else {
				this.angle = angle;
			}
		}

		// Casts
		public static implicit operator float(Angle a) {
			return a?.angle ?? 0;
		}
		public static implicit operator Angle(float a) {
			return new Angle { angle = a };
		}
		public static implicit operator Angle(AngleAmount a) {
			return new Angle { angle = a?.angle ?? 0f };
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
