﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Vec4d : ICSerializable {
		public float x;
		public float y;
		public float z;
		public float w;

		public Vec4d() {
		}
		public Vec4d(float x, float y, float z, float w) {
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public void Serialize(CSerializerObject s, string name) {
			x = s.Serialize<float>(x);
			y = s.Serialize<float>(y);
			z = s.Serialize<float>(z);
			w = s.Serialize<float>(w);
		}
		public static Vec4d Zero => new Vec4d();
		public static Vec4d One => new Vec4d(1,1,1,1);

		public static implicit operator Vec4d(Vector4 v) {
			return new Vec4d(v.x, v.y, v.z, v.w);
		}
		public static implicit operator Vector4(Vec4d v) {
			return new Vector4(v.x, v.y, v.z, v.w);
		}

		public override string ToString() {
			return $"Vec4d({x}, {y}, {z}, {w})";
		}
	}
}
