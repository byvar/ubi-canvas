using System;
using System.Collections.Generic;

namespace UbiArt {
	public class SerializableCache {
		public SerializableCache(ISystemLogger systemLog) {
			SystemLog = systemLog;
			Structs = new Dictionary<Type, Dictionary<StringID, ICSerializable>>();
		}

		protected ISystemLogger SystemLog { get; }

		public Dictionary<Type, Dictionary<StringID, ICSerializable>> Structs { get; }

		public T Get<T>(StringID id)
			where T : class, ICSerializable {
			if (id == null)
				return default;

			Type type = typeof(T);

			if (!Structs.ContainsKey(type) || !Structs[type].ContainsKey(id))
				return default;

			return (T)Structs[type][id];
		}

		public void Add<T>(StringID id, T serializable)
			where T : class, ICSerializable {
			Type type = typeof(T);

			if (!Structs.ContainsKey(type))
				Structs[type] = new Dictionary<StringID, ICSerializable>();

			if (!Structs[type].ContainsKey(id))
				Structs[type][id] = serializable;
			else
				SystemLog?.LogWarning("Duplicate StringID {0} for type {1}", id, type);
		}

		public void Clear() => Structs.Clear();
	}
}