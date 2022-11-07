using UbiArt;

namespace UbiCanvas {
	public abstract class UnityData {
		public UnityDataStorage Storage { get; protected set; }
		public Context Context => Storage.Context;

		protected object _LinkedObject { get; private set; }

		protected void Init(UnityDataStorage storage, object linkedObject) {
			Storage = storage;
			_LinkedObject = linkedObject;
		}
	}
	public abstract class UnityData<T> : UnityData {
		public T LinkedObject => (T)_LinkedObject;

		public void Init(UnityDataStorage storage, T linkedObject) {
			base.Init(storage, linkedObject);
		}
	}
}