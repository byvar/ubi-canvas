using UbiArt;

namespace UbiCanvas {
	public abstract class Unity_Data {
		public Unity_DataStorage Storage { get; protected set; }
		public Context Context => Storage.Context;

		protected object _LinkedObject { get; private set; }

		protected void Init(Unity_DataStorage storage, object linkedObject) {
			Storage = storage;
			_LinkedObject = linkedObject;
		}
	}
	public abstract class Unity_Data<T> : Unity_Data {
		public T LinkedObject => (T)_LinkedObject;

		public void Init(Unity_DataStorage storage, T linkedObject) {
			base.Init(storage, linkedObject);
		}
	}
}