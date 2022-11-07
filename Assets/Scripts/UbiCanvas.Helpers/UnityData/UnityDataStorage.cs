using System.Collections.Generic;
using UbiArt;

namespace UbiCanvas {
	public class UnityDataStorage {
		public Context Context { get; protected set; }

		private void Register(Context context) {
			Context = context;
			Context.StoreObject<UnityDataStorage>(ContextKey, this);
		}
		public UnityDataStorage(Context context) {
			Register(context);
		}

		public static string ContextKey => nameof(UnityDataStorage);

		protected Dictionary<object, UnityData> UnityDataDictionary { get; set; } = new Dictionary<object, UnityData>();
		public T GetUnityData<T, U>(U obj) where T : UnityData<U>, new() {
			if (!UnityDataDictionary.ContainsKey(obj)) {
				var data = new T();
				data.Init(this, obj);
				UnityDataDictionary[obj] = data;
			}
			return (T)UnityDataDictionary[obj];
		}
	}
}