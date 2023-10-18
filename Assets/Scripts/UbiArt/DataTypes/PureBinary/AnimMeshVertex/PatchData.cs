namespace UbiArt.Animation {
	// See: ITF::PatchData::serialize
	public class PatchData : CSerializable {
		public ushort uvsIndex;
		public byte alpha1;
		public byte alpha2;
		public Vec2d[] points = new Vec2d[4];

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uvsIndex = s.Serialize<ushort>(uvsIndex, name: "uvsIndex");
			alpha1 = s.Serialize<byte>(alpha1, name: "mesh1");
			alpha2 = s.Serialize<byte>(alpha2, name: "mesh2");
			for (int i = 0; i < points.Length; i++) {
				points[i] = s.SerializeObject<Vec2d>(points[i], name: $"points[{i}]");
			}
		}
	}
}
