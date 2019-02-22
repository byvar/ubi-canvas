using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Container<T> : IList<T> {
		List<T> container = new List<T>();

		public Container(Reader reader) {
			uint count = reader.ReadUInt32();
			if (Type.GetTypeCode(typeof(T)) != TypeCode.Object) {
				for (int i = 0; i < count; i++) {
					T obj;
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
					container.Add(obj);
				}
			} else if (typeof(T) == typeof(Vector2)) {
				for (int i = 0; i < count; i++) {
					container.Add((T)(object)reader.ReadVector2());
				}
			} else if (typeof(T) == typeof(Vector3)) {
				for (int i = 0; i < count; i++) {
					container.Add((T)(object)reader.ReadVector3());
				}
			} else if (typeof(T) == typeof(Vector4)) {
				for (int i = 0; i < count; i++) {
					container.Add((T)(object)reader.ReadVector4());
				}
			} else if (typeof(T) == typeof(Color)) {
				for (int i = 0; i < count; i++) {
					container.Add((T)(object)reader.ReadColor());
				}
			} else {
				for (int i = 0; i < count; i++) {
					var ctor = typeof(T).GetConstructor(new Type[] { typeof(Reader) });
					var obj = (T)ctor.Invoke(new object[] { reader });
					container.Add(obj);
				}
			}
		}

		#region List Interface
		public T this[int index] {
			get {
				return ((IList<T>)container)[index];
			}
			set {
				((IList<T>)container)[index] = value;
			}
		}

		public int Count => ((IList<T>)container).Count;

		public bool IsReadOnly => ((IList<T>)container).IsReadOnly;

		public void Add(T item) {
			((IList<T>)container).Add(item);
		}

		public void Clear() {
			((IList<T>)container).Clear();
		}

		public bool Contains(T item) {
			return ((IList<T>)container).Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex) {
			((IList<T>)container).CopyTo(array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator() {
			return ((IList<T>)container).GetEnumerator();
		}

		public int IndexOf(T item) {
			return ((IList<T>)container).IndexOf(item);
		}

		public void Insert(int index, T item) {
			((IList<T>)container).Insert(index, item);
		}

		public bool Remove(T item) {
			return ((IList<T>)container).Remove(item);
		}

		public void RemoveAt(int index) {
			((IList<T>)container).RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return ((IList<T>)container).GetEnumerator();
		}
		#endregion
	}
}
