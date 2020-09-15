using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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
			s.Serialize<float>(ref x);
			s.Serialize<float>(ref y);
		}

		public override string ToString() {
			return $"Vec2d({x}, {y})";
		}

		public static readonly Vec2d zero = new Vec2d();
		public static readonly Vec2d one = new Vec2d(1f, 1f);


		public static implicit operator Vec2d(UnityEngine.Vector2 v) {
			return new Vec2d() {
				x = v.x,
				y = v.y
			};
		}
		public static implicit operator UnityEngine.Vector2(Vec2d v) {
			return new UnityEngine.Vector2(v.x, v.y);
		}
	}
}
