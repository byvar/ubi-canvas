using UbiCanvas;

namespace UbiArt {
	public static class ContextExtensions {
		public static UnityDataStorage GetUnityDataStorage(this CSerializerObject s) => s.Context.GetUnityDataStorage();
		public static UnityDataStorage GetUnityDataStorage(this Context c) {
			return c.GetStoredObject<UnityDataStorage>(UnityDataStorage.ContextKey) ?? new UnityDataStorage(c);
		}
	}
}