using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class CList<T> : IList<T>, ICSerializable, IObjectContainer {
		List<T> container = new List<T>();

		public void Serialize(CSerializerObject s, string name) {
			uint count = (uint)container.Count;
			count = s.Serialize<uint>(count, name: name);
			if(count != container.Count) Resize((int)count);
			string typeName = "VAL";
			if (count > 0 && s.GetTagCode(typeof(T)) == 200) {
				typeName = null;
			}
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.SerializeGeneric<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
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

		public void Resize(int sz) {
			int cur = container.Count;
			if (sz < cur)
				container.RemoveRange(sz, cur - sz);
			else if (sz > cur) {
				if (sz > container.Capacity) container.Capacity = sz;
				container.AddRange(Enumerable.Repeat(default(T), sz - cur));
			}
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return ((IList<T>)container).GetEnumerator();
		}
		#endregion
	}
}
