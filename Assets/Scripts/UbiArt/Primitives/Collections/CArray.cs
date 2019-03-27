using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class CArray<T> : IList<T>, ICSerializable, IObjectContainer {
		T[] container;

		public CArray() {
			container = new T[0];
		}

		public void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			s.Serialize<uint>(ref count, name: name);
			if (count != (uint)Count) {
				Array.Resize(ref container, (int)count);
			}
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				s.Serialize<T>(ref obj, name: name, index: i);
				container[i] = obj;
			}
		}

		#region List interface
		public T this[int index] { get => ((IList<T>)container)[index]; set => ((IList<T>)container)[index] = value; }

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
