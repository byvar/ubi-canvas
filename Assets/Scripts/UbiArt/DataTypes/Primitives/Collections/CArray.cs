using System;
using System.Collections;
using System.Collections.Generic;

namespace UbiArt {
	[SerializeEmbed]
	public class CArray<T> : IList<T>, ICSerializable, IObjectContainer {
		protected T[] container = new T[0];

		public CArray() {}
		public CArray(T[] array) { container = array; }

		public virtual void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			count = s.Serialize<uint>(count, name: name);
			if (count != (uint)Count) {
				Array.Resize(ref container, (int)count);
			}
			string typeName = "VAL";
			if (count > 0 && !s.IsValueType(typeof(T))) {
				typeName = null;
			}
			//s.EnterEmbed();
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.SerializeGeneric<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
			}
			//s.ExitEmbed();
		}

		public void SetContainer(T[] container) {
			this.container = container;
		}

		#region List interface
		public T this[int index] { get => ((IList<T>)container)[index]; set => ((IList<T>)container)[index] = value; }

		public int Count => ((IList<T>)container).Count;

		public bool IsReadOnly => ((IList<T>)container).IsReadOnly;

		public void Add(T item) {
			Array.Resize(ref container, Count+1);
			container[Count - 1] = item;
		}

		public void Clear() {
			Array.Resize(ref container, 0);
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
			int removeIndex = IndexOf(item);
			if (removeIndex != -1) {
				for (int i = removeIndex + 1; i < container.Length; i++) {
					container[i-1] = container[i];
				}
				Array.Resize(ref container, container.Length-1);
				return true;
			}
			return false;
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
