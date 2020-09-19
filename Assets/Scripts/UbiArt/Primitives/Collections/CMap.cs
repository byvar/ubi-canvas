using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class CMap<TKey,TValue> : IDictionary<TKey,TValue>, ICSerializable, IObjectContainer {
		Dictionary<TKey, TValue> container = new Dictionary<TKey, TValue>();


		public void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			count = s.Serialize<uint>(count, name: name);
			List<KeyValuePair<TKey, TValue>> copy = new Dictionary<TKey, TValue>(container).ToList();
			//copy.Sort(
			container.Clear();
			for (int i = 0; i < count; i++) {
				TKey key = default;
				TValue val = default;
				if (i < copy.Count) {
					key = copy[i].Key;
					val = copy[i].Value;
				}
				if (s.ArrayEntryStart(name: name, index: i)) {
					key = s.SerializeGeneric(key, name: "KEY");
					val = s.SerializeGeneric(val, name: "VAL");
					s.ArrayEntryStop();
				}
				Add(key, val);
			}
		}

		#region Dictionary interface
		public TValue this[TKey key] { get => ((IDictionary<TKey, TValue>)container)[key]; set => ((IDictionary<TKey, TValue>)container)[key] = value; }

		public ICollection<TKey> Keys => ((IDictionary<TKey, TValue>)container).Keys;

		public ICollection<TValue> Values => ((IDictionary<TKey, TValue>)container).Values;

		public int Count => ((IDictionary<TKey, TValue>)container).Count;

		public bool IsReadOnly => ((IDictionary<TKey, TValue>)container).IsReadOnly;

		public void Add(TKey key, TValue value) {
			((IDictionary<TKey, TValue>)container).Add(key, value);
		}

		public void Add(KeyValuePair<TKey, TValue> item) {
			((IDictionary<TKey, TValue>)container).Add(item);
		}

		public void Clear() {
			((IDictionary<TKey, TValue>)container).Clear();
		}

		public bool Contains(KeyValuePair<TKey, TValue> item) {
			return ((IDictionary<TKey, TValue>)container).Contains(item);
		}

		public bool ContainsKey(TKey key) {
			return ((IDictionary<TKey, TValue>)container).ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {
			((IDictionary<TKey, TValue>)container).CopyTo(array, arrayIndex);
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() {
			return ((IDictionary<TKey, TValue>)container).GetEnumerator();
		}

		public bool Remove(TKey key) {
			return ((IDictionary<TKey, TValue>)container).Remove(key);
		}

		public bool Remove(KeyValuePair<TKey, TValue> item) {
			return ((IDictionary<TKey, TValue>)container).Remove(item);
		}

		public bool TryGetValue(TKey key, out TValue value) {
			return ((IDictionary<TKey, TValue>)container).TryGetValue(key, out value);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return ((IDictionary<TKey, TValue>)container).GetEnumerator();
		}
		#endregion
	}
}
