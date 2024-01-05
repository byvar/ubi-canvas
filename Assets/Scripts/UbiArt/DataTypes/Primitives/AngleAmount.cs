using System;

namespace UbiArt {
	public class AngleAmount : ICSerializable {
		public float angle;
		public void Serialize(CSerializerObject s, string name) {
			angle = s.Serialize<float>(angle);
		}

		// Constructors
		public AngleAmount() { }
		public AngleAmount(float angle, bool degrees = false) {
			if (degrees) {
				EulerAngle = angle;
			} else {
				this.angle = angle;
			}
		}

		// Casts
		public static implicit operator float(AngleAmount a) {
			return a?.angle ?? 0;
		}
		public static implicit operator AngleAmount(float a) {
			return new AngleAmount { angle = a };
		}
		public static implicit operator AngleAmount(Angle a) {
			return new AngleAmount { angle = a?.angle ?? 0f };
		}

		public float EulerAngle {
			get {
				return angle * Rad2Deg;
			}
			set {
				angle = value * Deg2Rad;
			}
		}
		public override string ToString() => $"AngleAmount({angle}rad|{EulerAngle}°)";

		private readonly float Deg2Rad = (MathF.PI * 2) / 360f;
		private readonly float Rad2Deg = 360f / (MathF.PI * 2);
	}
}
