using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public struct Nullable<T> {
		public bool read;
		public T obj;
		
		public Nullable(Reader reader) {
			read = reader.ReadBoolean();
			if (read) {
				if (Type.GetTypeCode(typeof(T)) != TypeCode.Object) {
					switch (Type.GetTypeCode(typeof(T))) {
						case TypeCode.Boolean: obj = (T)(object)reader.ReadBoolean(); break;
						case TypeCode.Byte: obj = (T)(object)reader.ReadByte(); break;
						case TypeCode.Char: obj = (T)(object)reader.ReadChar(); break;
						case TypeCode.String: obj = (T)(object)reader.ReadString(); break;
						case TypeCode.Single: obj = (T)(object)reader.ReadSingle(); break;
						case TypeCode.Double: obj = (T)(object)reader.ReadDouble(); break;
						case TypeCode.UInt16: obj = (T)(object)reader.ReadUInt16(); break;
						case TypeCode.UInt32: obj = (T)(object)reader.ReadUInt32(); break;
						case TypeCode.UInt64: obj = (T)(object)reader.ReadUInt64(); break;
						case TypeCode.Int16: obj = (T)(object)reader.ReadInt16(); break;
						case TypeCode.Int32: obj = (T)(object)reader.ReadInt32(); break;
						case TypeCode.Int64: obj = (T)(object)reader.ReadInt64(); break;
						default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(typeof(T)));
					}
				} else if (typeof(T) == typeof(Vector2)) {
					obj = (T)(object)reader.ReadVector2();
				} else if (typeof(T) == typeof(Vector3)) {
					obj = (T)(object)reader.ReadVector3();
				} else if (typeof(T) == typeof(Vector4)) {
					obj = (T)(object)reader.ReadVector4();
				} else if (typeof(T) == typeof(Color)) {
					obj = (T)(object)reader.ReadColor();
				} else {
					var ctor = typeof(T).GetConstructor(new Type[] { typeof(Reader) });
					obj = (T)ctor.Invoke(new object[] { reader });
				}
			} else {
				obj = default(T);
			}
		}
	}
}
