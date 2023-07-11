namespace UbiArt.Engine3D {
	public class Matrix44 : CSerializable {
		public Vec4d Column0 { get; set; }
		public Vec4d Column1 { get; set; }
		public Vec4d Column2 { get; set; }
		public Vec4d Column3 { get; set; }


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Column0 = s.SerializeObject<Vec4d>(Column0, name: nameof(Column0));
			Column1 = s.SerializeObject<Vec4d>(Column1, name: nameof(Column1));
			Column2 = s.SerializeObject<Vec4d>(Column2, name: nameof(Column2));
			Column3 = s.SerializeObject<Vec4d>(Column3, name: nameof(Column3));
		}
	}
}
