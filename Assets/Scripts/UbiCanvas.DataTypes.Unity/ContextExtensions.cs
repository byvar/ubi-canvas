using UbiCanvas;

namespace UbiArt {
	public static class ContextExtensions {
		public static Unity_DataStorage GetUnityDataStorage(this CSerializerObject s) => s.Context.GetUnityDataStorage();
		public static Unity_DataStorage GetUnityDataStorage(this Context c) {
			return c.GetStoredObject<Unity_DataStorage>(Unity_DataStorage.ContextKey) ?? new Unity_DataStorage(c);
		}
	}
}