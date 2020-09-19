using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Matrix44 : ICSerializable {
		public Matrix4x4 matrix;

		public void Serialize(CSerializerObject s, string name) {
			/*Debug.LogError(s.Position + ": Encountered Matrix44 with name " + name);
			throw new Exception(s.Position + ": Encountered Matrix44 with name " + name);*/
			matrix.m00 = s.Serialize<float>(matrix.m00);
			matrix.m01 = s.Serialize<float>(matrix.m01);
			matrix.m02 = s.Serialize<float>(matrix.m02);
			matrix.m03 = s.Serialize<float>(matrix.m03);
			matrix.m10 = s.Serialize<float>(matrix.m10);
			matrix.m11 = s.Serialize<float>(matrix.m11);
			matrix.m12 = s.Serialize<float>(matrix.m12);
			matrix.m13 = s.Serialize<float>(matrix.m13);
			matrix.m20 = s.Serialize<float>(matrix.m20);
			matrix.m21 = s.Serialize<float>(matrix.m21);
			matrix.m22 = s.Serialize<float>(matrix.m22);
			matrix.m23 = s.Serialize<float>(matrix.m23);
			matrix.m30 = s.Serialize<float>(matrix.m30);
			matrix.m31 = s.Serialize<float>(matrix.m31);
			matrix.m32 = s.Serialize<float>(matrix.m32);
			matrix.m33 = s.Serialize<float>(matrix.m33);
		}
	}
}
