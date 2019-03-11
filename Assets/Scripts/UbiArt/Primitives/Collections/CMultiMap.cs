using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class CMultiMap<TKey, TValue> : IDictionary<TKey, TValue>, ICSerializable {
		Dictionary<TKey, HashSet<TValue>> container = new Dictionary<TKey, HashSet<TValue>>();
		
		public void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			s.Serialize<uint>(ref count, name: name);
			List<KeyValuePair<TKey, TValue>> entries = GetAll();
			//copy.Sort(
			container.Clear();
			for (int i = 0; i < count; i++) {
				TKey key = default;
				TValue val = default;
				if (i < entries.Count) {
					key = entries[i].Key;
					val = entries[i].Value;
				}
				s.Serialize(ref key, name: "KEY", index: i); // todo: check if names are correct. the RLC multimap uses enum names as keys
				s.Serialize(ref val, name: "VAL", index: i);
				Add(key, val);
			}
		}

		public List<KeyValuePair<TKey, TValue>> GetAll() {
			List<KeyValuePair<TKey, TValue>> kvs = new List<KeyValuePair<TKey, TValue>>();
			foreach (TKey k in Keys) {
				kvs.AddRange(container[k].Select(v => new KeyValuePair<TKey, TValue>(k, v)));
			}
			return kvs;
		}

		#region Dictionary interface
		public TValue this[TKey key] {
			get {
				if (container.ContainsKey(key)) {
					return container[key].FirstOrDefault();
				} else return default;
			}
			set {
				if (!container.ContainsKey(key)) {
					container[key] = new HashSet<TValue>();
				}
				container[key].Add(value);
			}
		}

		public ICollection<TKey> Keys => container.Keys;

		public ICollection<TValue> Values {
			get {
				List<TValue> newValues = new List<TValue>();
				ICollection<HashSet<TValue>> values = ((IDictionary<TKey, HashSet<TValue>>)container).Values;
				foreach (HashSet<TValue> set in values) {
					newValues.AddRange(set);
				}
				return newValues;
			}
		}

		public int Count {
			get {
				return container.Keys.Sum(k => container[k].Count);
				/*int count = 0;
				foreach (TKey key in Keys) {
					if (container[key] != null) count += container[key].Count;
				}
				return count;*/
			}
		}

		public bool IsReadOnly => throw new NotImplementedException();

		public void Add(TKey key, TValue value) {
			this[key] = value;
		}

		public void Add(KeyValuePair<TKey, TValue> item) {
			this[item.Key] = item.Value;
		}

		public void Clear() {
			container.Clear();
		}

		public bool Contains(KeyValuePair<TKey, TValue> item) {
			if (!ContainsKey(item.Key)) return false;
			if (!container[item.Key].Contains(item.Value)) return false;
			return true;
		}

		public bool ContainsKey(TKey key) {
			return container.ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) {
			if (array == null)
				throw new ArgumentNullException("array");
			if (index < 0)
				throw new ArgumentOutOfRangeException("arrayIndex");
			if (array.Rank > 1)
				throw new ArgumentException("array is multidimensional.");
			if (array.Length - index < Count)
				throw new ArgumentException("Not enough elements after index in the destination array.");
			IEnumerator<KeyValuePair<TKey, TValue>> e = GetEnumerator();
			for (int i = 0; i < Count; ++i) {
				array.SetValue(e.Current, i + index);
				e.MoveNext();
			}
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() {
			return GetAll().GetEnumerator();
		}

		public bool Remove(TKey key) {
			return container.Remove(key);
		}

		public bool Remove(KeyValuePair<TKey, TValue> item) {
			if (ContainsKey(item.Key)) {
				if (container[item.Key].Contains(item.Value)) {
					container[item.Key].Remove(item.Value);
					if (container[item.Key].Count == 0) {
						Remove(item.Key);
					}
					return true;
				}
			}
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value) {
			if (!container.ContainsKey(key)) {
				value = default;
				return false;
			}
			value = this[key];
			return true;
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}
		#endregion
	}
}
