using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt {
	[SerializeEmbed]
	public class CList<T> : IList<T>, ICSerializable, IObjectContainer {
		protected List<T> container = new List<T>();

		public CList() { }
		public CList(List<T> list) { container = list; }

		public virtual void Serialize(CSerializerObject s, string name) {
			uint count = (uint)container.Count;
			count = s.Serialize<uint>(count, name: name);
			if(count != container.Count) Resize((int)count);
			string typeName = "VAL";
			if (count > 0 && !s.IsValueType(typeof(T))) {
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
		public void SetContainer(List<T> container) {
			this.container = container;
		}

		#region List Interface
		public T this[int index] {
			get {
				return container[index];
			}
			set {
				container[index] = value;
			}
		}

		public int Count => container.Count;

		public bool IsReadOnly => ((IList<T>)container).IsReadOnly;

		public void Add(T item) {
			container.Add(item);
		}

		public void Clear() {
			container.Clear();
		}

		public bool Contains(T item) {
			return container.Contains(item);
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
			return container.GetEnumerator();
		}
		#endregion
	}
}
