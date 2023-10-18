namespace UbiArt.Animation {
	// See: ITF::PatchData::serialize
	public class PatchData : CSerializable {
		public ushort uvsIndex;
		public byte mesh1;
		public byte mesh2;
		public Vec2d[] points = new Vec2d[4];

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uvsIndex = s.Serialize<ushort>(uvsIndex, name: "uvsIndex");
			mesh1 = s.Serialize<byte>(mesh1, name: "mesh1");
			mesh2 = s.Serialize<byte>(mesh2, name: "mesh2");
			for (int i = 0; i < points.Length; i++) {
				points[i] = s.SerializeObject<Vec2d>(points[i], name: $"points[{i}]");
			}
		}
	}
}
