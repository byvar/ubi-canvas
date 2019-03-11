using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UbiArt {
	/// <summary>
	/// Transformation matrix storing position, rotation and scale. Also, an unknown vector4 and type.
	/// </summary>
	public class Matrix {
		public Pointer offset;
		public Matrix4x4 m;
		public Matrix4x4? scaleMatrix;
		public Vector4? v;

		public Matrix(Pointer offset, Matrix4x4 matrix, Vector4? vec) {
			this.offset = offset;
			this.m = matrix;
			this.v = vec;
		}

		public static Matrix Identity {
			get {
				return new Matrix(null, Matrix4x4.identity, Vector4.one);
			}
		}

		public void SetScaleMatrix(Matrix4x4 scaleMatrix) {
			this.scaleMatrix = scaleMatrix;
		}

		public Vector3 GetPosition(bool convertAxes = false) {
			if (convertAxes) {
				return new Vector3(m[0, 3], m[2, 3], m[1, 3]);
			} else {
				return new Vector3(m[0, 3], m[1, 3], m[2, 3]);
			}
		}

		public Vector3 GetScale(bool convertAxes = false) {
			if (scaleMatrix.HasValue) {
				if (convertAxes) {
					return new Vector3(scaleMatrix.Value.GetColumn(0).magnitude, scaleMatrix.Value.GetColumn(2).magnitude, scaleMatrix.Value.GetColumn(1).magnitude);
				} else {
					return new Vector3(scaleMatrix.Value.GetColumn(0).magnitude, scaleMatrix.Value.GetColumn(1).magnitude, scaleMatrix.Value.GetColumn(2).magnitude);
				}
			} else if (v.HasValue) {
				if (convertAxes) {
					return new Vector3(v.Value.x, v.Value.z, v.Value.y);
				} else {
					return new Vector3(v.Value.x, v.Value.y, v.Value.z);
				}
			} else {
				if (convertAxes) {
					return new Vector3(m.GetColumn(0).magnitude, m.GetColumn(2).magnitude, m.GetColumn(1).magnitude);
				} else {
					return new Vector3(m.GetColumn(0).magnitude, m.GetColumn(1).magnitude, m.GetColumn(2).magnitude);
				}
			}
		}


		public static Matrix operator *(Matrix x, Matrix y) {
			return new Matrix(x.offset, x.m * y.m, x.v);
		}

		public static Matrix Invert(Matrix src) {
			Matrix dest = new Matrix(src.offset, new Matrix4x4(), src.v);
			/*m.v.x = 1f / m.m[0, 0];
			m.v.y = 1f / m.m[1, 1];
			m.v.z = 1f / m.m[2, 2];*/
			/*m.m[0, 0] = m.v.x;
			m.m[1, 1] = m.v.y;
			m.m[2, 2] = m.v.z;*/
			dest.m.SetRow(0, src.m.GetRow(0));
			dest.m.SetRow(1, src.m.GetRow(1));
			dest.m.SetRow(2, src.m.GetRow(2));
			dest.m.SetRow(3, src.m.GetRow(3));

			/*float v4 = src.m.m22 * src.m.m11 - src.m.m12 * src.m.m21;
			dest.m.m00 = v4;
			float v5 = v4 * src.m.m00;
			float v6 = src.m.m02 * src.m.m21 - src.m.m01 * src.m.m22;
			dest.m.m01 = v6;
			float v7 = v5 + src.m.m10 * v6;
			float v8 = src.m.m01 * src.m.m12 - src.m.m02 * src.m.m11;
			dest.m.m02 = v8;
			float determinant = v7 + src.m.m20 * v8;
			dest.m.m10 = src.m.m20 * src.m.m12 - src.m.m10 * src.m.m22;
			dest.m.m20 = src.m.m10 * src.m.m21 - src.m.m20 * src.m.m11;
			dest.m.m11 = src.m.m22 * src.m.m00 - src.m.m20 * src.m.m02;
			dest.m.m21 = src.m.m01 * src.m.m20 - src.m.m21 * src.m.m00;
			dest.m.m12 = src.m.m02 * src.m.m10 - src.m.m12 * src.m.m00;
			dest.m.m22 = src.m.m11 * src.m.m00 - src.m.m01 * src.m.m10;


			float invertedDeterminant = 1f / determinant;

			dest.m.m00 *= invertedDeterminant;
			dest.m.m10 *= invertedDeterminant;
			dest.m.m20 *= invertedDeterminant;

			dest.m.m01 *= invertedDeterminant;
			dest.m.m11 *= invertedDeterminant;
			dest.m.m21 *= invertedDeterminant;

			dest.m.m02 *= invertedDeterminant;
			dest.m.m12 *= invertedDeterminant;
			dest.m.m22 *= invertedDeterminant;*/
			dest.m.SetColumn(0, src.m.GetRow(0));
			dest.m.SetColumn(1, src.m.GetRow(1));
			dest.m.SetColumn(2, src.m.GetRow(2));

			dest.m.m03 = dest.m.m01 * -src.m.m13 + dest.m.m02 * -src.m.m23 + dest.m.m00 * -src.m.m03;
			dest.m.m13 = dest.m.m11 * -src.m.m13 + dest.m.m12 * -src.m.m23 + dest.m.m10 * -src.m.m03;
			dest.m.m23 = dest.m.m21 * -src.m.m13 + dest.m.m22 * -src.m.m23 + dest.m.m20 * -src.m.m03;

			dest.m.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
			return dest;
		}

		public Quaternion GetRotation(bool convertAxes = false) {
			float m00, m01, m02, m10, m11, m12, m20, m21, m22;
			if (v.HasValue && v.Value.x != 0 && v.Value.y != 0 && v.Value.z != 0) {
				m00 = m.m00 / v.Value.x;
				m01 = m.m01 / v.Value.y;
				m02 = m.m02 / v.Value.z;
				m10 = m.m10 / v.Value.x;
				m11 = m.m11 / v.Value.y;
				m12 = m.m12 / v.Value.z;
				m20 = m.m20 / v.Value.x;
				m21 = m.m21 / v.Value.y;
				m22 = m.m22 / v.Value.z;
			} else {
				m00 = m.m00;
				m01 = m.m01;
				m02 = m.m02;
				m10 = m.m10;
				m11 = m.m11;
				m12 = m.m12;
				m20 = m.m20;
				m21 = m.m21;
				m22 = m.m22;
			}

			float tr = m00 + m11 + m22;
			Quaternion q = new Quaternion();
			if (tr > 0) {
				float S = Mathf.Sqrt(tr + 1.0f) * 2; // S=4*qw 
				q.w = 0.25f * S;
				q.x = (m21 - m12) / S;
				q.y = (m02 - m20) / S;
				q.z = (m10 - m01) / S;
			} else if ((m00 > m11) && (m00 > m22)) {
				float S = Mathf.Sqrt(1.0f + m00 - m11 - m22) * 2; // S=4*qx 
				q.w = (m21 - m12) / S;
				q.x = 0.25f * S;
				q.y = (m01 + m10) / S;
				q.z = (m02 + m20) / S;
			} else if (m11 > m22) {
				float S = Mathf.Sqrt(1.0f + m11 - m00 - m22) * 2; // S=4*qy
				q.w = (m02 - m20) / S;
				q.x = (m01 + m10) / S;
				q.y = 0.25f * S;
				q.z = (m12 + m21) / S;
			} else {
				float S = Mathf.Sqrt(1.0f + m22 - m00 - m11) * 2; // S=4*qz
				q.w = (m10 - m01) / S;
				q.x = (m02 + m20) / S;
				q.y = (m12 + m21) / S;
				q.z = 0.25f * S;
			}

			/*Vector3 s = GetScale();

			// Normalize Scale from Matrix4x4
			float m00 = m[0, 0] / s.x;
			float m01 = m[0, 1] / s.y;
			float m02 = m[0, 2] / s.z;
			float m10 = m[1, 0] / s.x;
			float m11 = m[1, 1] / s.y;
			float m12 = m[1, 2] / s.z;
			float m20 = m[2, 0] / s.x;
			float m21 = m[2, 1] / s.y;
			float m22 = m[2, 2] / s.z;

			Quaternion q = new Quaternion();
			q.w = Mathf.Sqrt(Mathf.Max(0, 1 + m00 + m11 + m22)) / 2;
			q.x = Mathf.Sqrt(Mathf.Max(0, 1 + m00 - m11 - m22)) / 2;
			q.y = Mathf.Sqrt(Mathf.Max(0, 1 - m00 + m11 - m22)) / 2;
			q.z = Mathf.Sqrt(Mathf.Max(0, 1 - m00 - m11 + m22)) / 2;
			q.x *= Mathf.Sign(q.x * (m21 - m12));
			q.y *= Mathf.Sign(q.y * (m02 - m20));
			q.z *= Mathf.Sign(q.z * (m10 - m01));

			// q.Normalize()
			float qMagnitude = Mathf.Sqrt(q.w * q.w + q.x * q.x + q.y * q.y + q.z * q.z);
			q.w /= qMagnitude;
			q.x /= qMagnitude;
			q.y /= qMagnitude;
			q.z /= qMagnitude;*/

			if (convertAxes) {
				q = new Quaternion(q.x, q.z, q.y, -q.w);
				//q = q * Quaternion.Euler(new Vector3(0f, 0f, 0f));
				//Vector3 tempRot = q.eulerAngles;
				//if (isBoneMatrix) {
				//tempRot = new Vector3(-tempRot.x, -tempRot.z, -tempRot.y); // z = tempRot.y * sign(something)
				/*float signX = m00 == 0 ? 0 : Mathf.Sign(m00);
                float signY = m11 == 0 ? 0 : Mathf.Sign(m11);
                float signZ = m22 == 0 ? 0 : Mathf.Sign(m22);*/
				//float signX = 1f, signY = 1f, signZ = 1f;
				//tempRot = new Vector3(-tempRot.y * signY, -tempRot.x * signX, tempRot.z * signZ);
				//}
				//tempRot = new Vector3(tempRot.y, -tempRot.z, tempRot.x);

				//q = Quaternion.Euler(tempRot);
			}

			return q;
		}

		public static Matrix Read(Reader reader, Pointer offset) {
			Matrix mat = new Matrix(offset, new Matrix4x4(), null);
			mat.m.SetColumn(0, new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()));
			mat.m.SetColumn(1, new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()));
			mat.m.SetColumn(2, new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()));
			mat.m.SetColumn(3, new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()));
			mat.v = new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
			return mat;
		}

		// For writing
		public void SetTRS(Vector3 pos, Quaternion rot, Vector3 scale, bool convertAxes = false, bool setVec = false) {
			if (convertAxes) {
				Vector3 tempRot = rot.eulerAngles;
				tempRot = new Vector3(tempRot.z, tempRot.x, -tempRot.y);
				rot = Quaternion.Euler(tempRot);
				scale = new Vector3(scale.x, scale.z, scale.y);
				pos = new Vector3(pos.x, pos.z, pos.y);
			}
			m.SetTRS(pos, rot, scale);
			if (setVec) {
				v = new Vector4(1f * scale.x, 1f * scale.y, 1f * scale.z, v.HasValue ? v.Value.w : 1f);
			}
		}

		public void Write(Writer writer) {
			Pointer.Goto(ref writer, offset);

			for (int i = 0; i < 4; i++) {
				Vector4 col = m.GetColumn(i);
				for (int j = 0; j < 4; j++) {
					writer.Write(col[j]);
				}
			}
			if (v.HasValue) {
				for (int j = 0; j < 4; j++) {
					writer.Write(v.Value[j]);
				}
			}
		}
	}
}