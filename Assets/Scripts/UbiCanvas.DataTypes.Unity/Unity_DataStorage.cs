using System.Collections.Generic;
using UbiArt;

namespace UbiCanvas {
	public class Unity_DataStorage {
		public Context Context { get; protected set; }

		private void Register(Context context) {
			Context = context;
			Context.StoreObject<Unity_DataStorage>(ContextKey, this);
		}
		public Unity_DataStorage(Context context) {
			Register(context);
		}

		public static string ContextKey => nameof(Unity_DataStorage);

		protected Dictionary<object, Unity_Data> UnityDataDictionary { get; set; } = new Dictionary<object, Unity_Data>();
		public T GetUnityData<T, U>(U obj) where T : Unity_Data<U>, new() {
			if (!UnityDataDictionary.ContainsKey(obj)) {
				var data = new T();
				data.Init(this, obj);
				UnityDataDictionary[obj] = data;
			}
			return (T)UnityDataDictionary[obj];
		}
	}
}