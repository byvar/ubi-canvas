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
			s.Serialize<float>(ref matrix.m00);
			s.Serialize<float>(ref matrix.m01);
			s.Serialize<float>(ref matrix.m02);
			s.Serialize<float>(ref matrix.m03);
			s.Serialize<float>(ref matrix.m10);
			s.Serialize<float>(ref matrix.m11);
			s.Serialize<float>(ref matrix.m12);
			s.Serialize<float>(ref matrix.m13);
			s.Serialize<float>(ref matrix.m20);
			s.Serialize<float>(ref matrix.m21);
			s.Serialize<float>(ref matrix.m22);
			s.Serialize<float>(ref matrix.m23);
			s.Serialize<float>(ref matrix.m30);
			s.Serialize<float>(ref matrix.m31);
			s.Serialize<float>(ref matrix.m32);
			s.Serialize<float>(ref matrix.m33);
		}
	}
}
