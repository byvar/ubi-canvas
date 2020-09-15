using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Vec3d : ICSerializable {
		public float x;
		public float y;
		public float z;

		public Vec3d() {
		}
		public Vec3d(float x, float y, float z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<float>(ref x);
			s.Serialize<float>(ref y);
			s.Serialize<float>(ref z);
		}
		public static Vec3d zero => new Vec3d();
		public static Vec3d one => new Vec3d() { x = 1f, y = 1f, z = 1f };

		public static implicit operator Vec3d(UnityEngine.Vector3 v) {
			return new Vec3d() {
				x = v.x,
				y = v.y,
				z = v.z
			};
		}
		public static implicit operator UnityEngine.Vector3(Vec3d v) {
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public override string ToString() {
			return $"Vec3d({x}, {y}, {z})";
		}
	}
}
