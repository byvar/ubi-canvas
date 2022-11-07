namespace UbiArt.ITF {
	public partial class MultiplePath : CSerializable {
		public CListO<Path> PathValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PathValues = s.SerializeObject<CListO<Path>>(PathValues, name: "PathValues");
		}
	}
}

