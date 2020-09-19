using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Angle : ICSerializable {
		public float angle;

		public void Serialize(CSerializerObject s, string name) {
			angle = s.Serialize<float>(angle);
		}

		// Constructors
		public Angle() { }
		public Angle(float angle) {
			this.angle = angle;
		}
		
		// Casts
		public static implicit operator float(Angle a) {
			return a.angle;
		}
		public static implicit operator Angle(float a) {
			return new Angle { angle = a };
		}
		public static implicit operator Angle(AngleAmount a) {
			return new Angle { angle = a.angle };
		}

		public float EulerAngle {
			get {
				return angle * Mathf.Rad2Deg;
			}
			set {
				angle = value * Mathf.Deg2Rad;
			}
		}
		public Vector3 VectorAngle {
			get {
				return new Vector3(0, 0, EulerAngle);
			}
			set {
				EulerAngle = value.z;
			}
		}
		public Quaternion QuaternionAngle {
			get {
				return Quaternion.Euler(0, 0, EulerAngle);
			}
			set {
				EulerAngle = value.eulerAngles.z;
			}
		}
		public override string ToString() {
			return "Angle(" + angle + "rad|" + EulerAngle + "°" +")";
		}
	}
}
