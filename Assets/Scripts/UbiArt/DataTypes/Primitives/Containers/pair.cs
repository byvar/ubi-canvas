namespace UbiArt {
	//[SerializeEmbed]
	public class pair<T1, T2> : ICSerializable, IObjectContainer { // Lowercase!
		public T1 Item1;
		public T2 Item2;

		public void Serialize(CSerializerObject s, string name) {
			//Item1 = s.SerializeGeneric<T1>(Item1, name: name, index: 0);
			//Item2 = s.SerializeGeneric<T2>(Item2, name: name, index: 1);
			Item1 = s.SerializeGeneric<T1>(Item1, name: "first");//, index: 0);
			Item2 = s.SerializeGeneric<T2>(Item2, name: "second");//, index: 1);
		}
		public pair() { }
		public pair(T1 Item1, T2 Item2) {
			this.Item1 = Item1;
			this.Item2 = Item2;
		}
	}
}
