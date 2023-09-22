namespace UbiArt {
	public interface IGeneric {
		public object GenericObject { get; set; }
		public StringID GenericClassName { get; set; }
		public bool IsNull { get; }

		public void SerializeClassName(CSerializerObject s);
		public void SerializeObject(CSerializerObject s);
	}
}
